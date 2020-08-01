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

    public class WorkflowBroker : IDisposable
    {
        readonly Dictionary<Type,ISink> Subscriptions;

        readonly Dictionary<ulong, Receiver<IWorkflowEvent>> Receivers;
        
        public FilePath TargetPath {get;}

        readonly StreamWriter OutStream;

        object locker;

        [MethodImpl(Inline)]
        public WorkflowBroker(FilePath target)
        {
            TargetPath = target ?? FilePath.Empty;
            Subscriptions = new Dictionary<Type,ISink>();
            Receivers = new Dictionary<ulong, Receiver<IWorkflowEvent>>();
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
            where E : IWorkflowEvent
                => Subscribe(Events.sink(receiver), model);

        public void Receive(ulong session, Action<IWorkflowEvent> receiver)
        {
            Receivers.TryAdd(session,new Receiver<IWorkflowEvent>((in IWorkflowEvent e) => receiver(e)));
        }

        public void Cancel(ulong session)
        {
            lock(locker)
                Receivers.Remove(session);
        }

        void Emit(IWorkflowEvent e)
        {
            z.iter(Receivers.Values, r => r(e));
            if(OutStream != null)
                lock(locker)
                    OutStream.WriteLine(e.Format());
        }
        
        public void Raise(IWorkflowEvent e)
        {
            Emit(e);
        }

        Outcome Subscribe(Action<IWorkflowEvent> receiver, IWorkflowEvent model)
        {
            if(Subscriptions.TryAdd(model.GetType(), Events.sink(receiver)))
                return true;
            else
                return (false, AppMsg.Warn($"Key for {model.GetType()} was previously added"));            
        }
    }
}