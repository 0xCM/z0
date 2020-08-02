//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static Flow;
    using static z;
    
    public struct WfContext : IWfContext<WfConfig>
    {
        [MethodImpl(Inline)]
        public static WfContext create(IAppContext root, CorrelationToken ct, WfConfig config, WfTermEventSink sink)
            => new WfContext(root, ct, config, sink);

        long CtProvider;

        readonly ulong SessionId;

        public WfTermEventSink TermSink {get;}
        
        public IAppContext ContextRoot {get;}
        
        public WfConfig ContextData {get;}

        public CorrelationToken Ct {get;}
        
        public WfBroker Broker {get;}
                
        [MethodImpl(Inline)]
        public WfContext(IAppContext root, CorrelationToken ct, WfConfig config, WfTermEventSink sink)
        {
            Ct = ct;
            ContextRoot = root;
            ContextData = config;
            TermSink = sink;
            SessionId = (ulong)now().Ticks;
            CtProvider = 1;       
            Broker = new WfBroker(root.AppPaths.AppDataRoot + FileName.Define("broker", FileExtensions.Csv), Ct);
            TermSink.Deposit(new OpeningWfContext(typeof(WfContext), Ct));
        }


        public void Dispose()
        {
            TermSink.Deposit(new ClosingWfContext(typeof(WfContext), Ct));
            TermSink.Dispose();
            Broker.Dispose();
        }
                
        public TAppPaths AppPaths
        {
            [MethodImpl(Inline)]
            get => ContextRoot.AppPaths;
        }

        public WfEventId Raise<E>(in E @event)
            where E : IWfEvent
        {
            TermSink.Deposit(@event);
            return @event.Id;
        }

        public void Emitting(string type, FilePath dst, CorrelationToken? ct = null)
            => Raise(new EmittingDataset(WfEventId.define(nameof(EmittingDataset), ct), type, dst));

        public void Emitting(string type, FolderPath dst, CorrelationToken? ct = null)
            => Raise(new EmittingDataset(WfEventId.define(nameof(EmittingDataset), ct), type, dst));

        public void Emitted(string type, uint count, FilePath dst, CorrelationToken? ct = null)
            => Raise(new DatasetEmitted(WfEventId.define(nameof(EmittingDataset), ct), type, count, dst));

        public CorrelationToken Running(string worker)
        {
            var ct = CorrelationToken.define((ulong)z.atomic(ref CtProvider));
            Raise(new WfStepRunning(worker, ct));
            return ct;
        }

        public CorrelationToken Running(string worker, string detail, CorrelationToken? ct = null)
        {
            var correlation = ct ?? CorrelationToken.define((ulong)z.atomic(ref CtProvider));
            Raise(new WfStepRunning(worker, detail, correlation));
            return correlation;
        }

        public void Running(string worker, CorrelationToken ct)
        {
            Raise(new WfStepRunning(worker, ct));
        }

        public void Status(string msg, CorrelationToken? ct = null)
        {   
            Raise(new WfStatus(msg,ct));            
        }

        public void Created(string worker, CorrelationToken? ct = null)
        {   
            Raise(new WorkerCreated(worker,ct));            
        }

        public void Finished(string worker, CorrelationToken? ct = null)
        {   
            Raise(new WorkerFinished(worker,ct));            
        }

        public void Initialized(string worker, CorrelationToken? ct = null)
        {
            Raise(new WorkerInitialized(worker, ct));
        }
        
        public void Ran(string worker, CorrelationToken? ct = null)
        {
            Raise(new WfStepFinished(worker, ct));            
        }

        public void Ran(string worker, string detail, CorrelationToken? ct = null)
        {
            Raise(new WfStepFinished(worker, detail, ct));
        }

        public void Ran(string worker, object detail, CorrelationToken? ct = null)
        {
            Raise(new WfStepFinished(worker, (detail ?? EmptyString).ToString(), ct));
        }
    }
}