//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static z;
    
    public struct WfContext : IWfContext<WfConfig>
    {
        [MethodImpl(Inline)]
        public static WfContext create(IAppContext root, WfConfig config, IMultiSink sink)
            => new WfContext(root, config, sink);

        long CtProvider;

        readonly ulong SessionId;

        public IMultiSink Sink {get;}
        
        public IAppContext ContextRoot {get;}
        
        public WfConfig ContextData {get;}

        public CorrelationToken Correlation {get;}
        
        public WfBroker Broker {get;}
                
        [MethodImpl(Inline)]
        public WfContext(IAppContext root, WfConfig config, IMultiSink sink)
        {
            SessionId = (ulong)now().Ticks;
            Sink = sink;
            ContextRoot = root;
            ContextData = config;
            CtProvider = 1;       
            Correlation = CorrelationToken.define(CtProvider);
            Broker = new WfBroker(root.AppPaths.AppDataRoot + FileName.Define("brokered", FileExtensions.Csv));
            Sink.Deposit(new OpeningWfContext(typeof(WfContext), Correlation));
        }


        public void Dispose()
        {
            Sink.Deposit(new ClosingWfContext(typeof(WfContext), Correlation));
        }
                
        public TAppPaths AppPaths
        {
            [MethodImpl(Inline)]
            get => ContextRoot.AppPaths;
        }

        public WfEventId Raise<E>(in E @event)
            where E : IWfEvent
        {
            Sink.Deposit(@event);
            return @event.Id;
        }

        public void Emitting(string type, FilePath dst)
            => Raise(new EmittingDataset(WfEventId.define(nameof(EmittingDataset)), type, dst));

        public void Emitting(string type, FolderPath dst)
            => Raise(new EmittingDataset(WfEventId.define(nameof(EmittingDataset)), type, dst));

        public void Emitted(string type, uint count, FilePath dst)
            => Raise(new DatasetEmitted(type, count, dst));

        public CorrelationToken Running(string worker)
        {
            var ct = CorrelationToken.define((ulong)z.atomic(ref CtProvider));
            Raise(new WfStepRunning(worker, ct));
            return ct;
        }

        public void Running(string worker, CorrelationToken ct)
        {
            Raise(new WfStepRunning(worker, ct));
        }

        public void Status(string msg, CorrelationToken? ct = null)
        {   
            Raise(new WfStatus(msg,ct));            
        }
        
        public CorrelationToken Running(string worker, string detail, CorrelationToken? ct = null)
        {
            var correlation = ct ?? CorrelationToken.define((ulong)z.atomic(ref CtProvider));
            Raise(new WfStepRunning(worker, detail, correlation));
            return correlation;
        }

        // public CorrelationToken Running(string worker, object detail, CorrelationToken? ct = null)
        // {
        //     var correlation = ct ?? CorrelationToken.define((ulong)z.atomic(ref CtProvider));
        //     Raise(new WfStepRunning(worker, (detail ?? EmptyString).ToString(), correlation));
        //     return correlation;
        // }

        public void Ran(string worker, CorrelationToken? ct = null)
        {
            var correlation = CorrelationToken.define((ulong)z.atomic(ref CtProvider));         
            Raise(new WfStepFinished(worker, correlation));            
        }

        public void Ran(string worker, string detail, CorrelationToken? ct = null)
        {
            var correlation = CorrelationToken.define((ulong)z.atomic(ref CtProvider));            
            Raise(new WfStepFinished(worker, detail, correlation));
        }

        public void Ran(string worker, object detail, CorrelationToken? ct = null)
        {
            var correlation = CorrelationToken.define((ulong)z.atomic(ref CtProvider));            
            Raise(new WfStepFinished(worker, (detail ?? EmptyString).ToString(), correlation));
        }
    }
}