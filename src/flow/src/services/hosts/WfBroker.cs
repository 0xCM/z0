//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    using static Konst;

    public class WfBroker : IDisposable
    {
        readonly Dictionary<Type,ISink> Subscriptions;

        readonly Dictionary<ulong, Receiver<IWfEvent>> Receivers;
        
        public FilePath TargetPath {get;}

        readonly StreamWriter OutStream;

        object locker;

        [MethodImpl(Inline)]
        public WfBroker(FilePath target)
        {
            TargetPath = target ?? FilePath.Empty;
            Subscriptions = new Dictionary<Type,ISink>();
            Receivers = new Dictionary<ulong, Receiver<IWfEvent>>();
            if(!TargetPath.IsNonEmpty)
                OutStream = TargetPath.Writer();
            locker = new object();
        }

        public void Dispose()
        {
            if(OutStream != null)
                OutStream.Dispose();
        }

        Outcome Subscribe<S,E>(S sink, E model)
            where E : IAppEvent
            where S : ISink
        {
            if(Subscriptions.TryAdd(typeof(E), sink))
                return true;
            else
                return (false, AppMsg.Warn($"Key for {model} was previously added for {sink}"));
        }

        [MethodImpl(Inline)]
        public Outcome Subscribe<E>(Action<E> receiver, E model = default)
            where E : IWfEvent
                => Subscribe(Events.sink(receiver), model);

        public void Receive(ulong session, Action<IWfEvent> receiver)
        {
            Receivers.TryAdd(session,new Receiver<IWfEvent>((in IWfEvent e) => receiver(e)));
        }

        public void Cancel(ulong session)
        {
            lock(locker)
                Receivers.Remove(session);
        }

        void Emit(IWfEvent e)
        {
            z.iter(Receivers.Values, r => r(e));
            if(OutStream != null)
                lock(locker)
                    OutStream.WriteLine(e.Format());
        }
        
        public void Raise(IWfEvent e)
        {
            Emit(e);
        }

        Outcome Subscribe(Action<IWfEvent> receiver, IWfEvent model)
        {
            if(Subscriptions.TryAdd(model.GetType(), Events.sink(receiver)))
                return true;
            else
                return (false, AppMsg.Warn($"Key for {model.GetType()} was previously added"));            
        }
    }
}