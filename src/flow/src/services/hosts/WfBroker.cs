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

        object locker;

        CorrelationToken Ct;
        
        [MethodImpl(Inline)]
        public WfBroker(FilePath target, CorrelationToken? ct = null)
        {
            Ct = ct ?? CorrelationToken.create();
            var @base = AppBase.Default;
            var paths = @base.AppPaths;
            Sink = WfTermEventSink.create(Ct);
            TargetPath = target ?? (paths.AppCaptureRoot + FileName.Define($"{@base.AppName}.broker", FileExtensions.Csv));
            Subscriptions = new Dictionary<Type,ISink>();
            Receivers = new Dictionary<ulong, Receiver<IAppEvent>>();
            locker = new object();                    
            Sink.Deposit(new WorkerInitialized(nameof(WfBroker), Ct));
        }

        public void Dispose()
        {            
            Sink.Deposit(new WfStepFinished(nameof(WfBroker), Ct));
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
        }

        void Emit(IAppEvent e)
        {
            z.iter(Receivers.Values, r => r(e));
        }

        public void Raise(IWfEvent e)
        {
            Emit(e);
        }

        public void Raise(IAppEvent e)
        {
            Emit(e);
        }
    }
}