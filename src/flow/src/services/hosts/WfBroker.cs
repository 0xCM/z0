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
    
    public class WfBroker : IWfBroker
    {
        readonly Dictionary<Type,ISink> Subscriptions;

        readonly Dictionary<ulong, Receiver<IAppEvent>> Receivers;
        
        public FilePath TargetPath {get;}

        public IWfEventSink Sink {get;}
        
        readonly StreamWriter OutStream;

        object locker;

        [MethodImpl(Inline)]
        public WfBroker(FilePath target)
        {
            Sink = new WfTermEventSink();
            TargetPath = target ?? FilePath.Empty;
            Subscriptions = new Dictionary<Type,ISink>();
            Receivers = new Dictionary<ulong, Receiver<IAppEvent>>();
            if(!TargetPath.IsNonEmpty)
                OutStream = TargetPath.Writer();
            locker = new object();
        }

        public void Dispose()
        {
            if(OutStream != null)
                OutStream.Dispose();
        }

        public void raise<E>(in E e)
            where E : IAppEvent
        {                
            Emit(e);
            
            if(Subscriptions.TryGetValue(e.GetType(), out var sink))
                ((IAppMsgSink)sink).Deposit(e);
            else
                term.print(e, e.Flair);
        }

        public Outcome Subscribe<S,E>(S sink, E model)
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
            where E : IAppEvent
                => Subscribe(Events.sink(receiver), model);

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

        void Emit(IAppEvent e)
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

        public void Raise(IAppEvent e)
        {
            Emit(e);
        }

        // public Outcome Subscribe(Action<IWfEvent> receiver, IWfEvent model)
        // {
        //     if(Subscriptions.TryAdd(model.GetType(), Events.sink(receiver)))
        //         return true;
        //     else
        //         return (false, AppMsg.Warn($"Key for {model.GetType()} was previously added"));            
        // }
    }
}