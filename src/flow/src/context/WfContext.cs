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

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public struct WfContext : IWfContext<WfConfig>
    {
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

        public FolderPath IndexRoot 
            => ContextRoot.AppPaths.ResourceRoot + FolderName.Define("index");


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

        public void Error(Exception e, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
        {
            const string CallerPattern = "An error was trapped by {0} on line {1} in {2}";
            const string Pattern = "{0}" + Eol + "{1}";
            var where = text.format(CallerPattern, caller, line, file);
            var what = e.ToString();
            var msg = AppMsg.NoCaller(text.format(Pattern, where, what), AppMsgKind.Error);
            Raise(wferror(msg,ct));
        }
        
        public void Emitting(string worker, string dsname, FilePath dst, CorrelationToken ct)
        {
            Raise(new EmittingDataset(worker, dsname, dst, ct));
        }

        public void Emitted(string worker, string dsname, uint count, FilePath dst, CorrelationToken ct)
        {
            Raise(new EmittedDataset(worker, dsname, count,  dst, ct));
        }

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

        public void Status<T>(string worker, T body, CorrelationToken ct)
        {   
            Raise(status(worker, body, ct));
        }

        public void Created(string worker, CorrelationToken? ct = null)
        {   
            Raise(new WorkerCreated(worker, correlate(ct)));            
        }

        public void Finished(string worker, CorrelationToken ct)
        {   
            Raise(new WorkerFinished(worker, ct));            
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

        public void RunningT<T>(string worker, T detail, CorrelationToken ct)
        {
            Raise(new WfStepRunning<T>(worker, detail, ct));
        }
        
        public void RanT<T>(string worker, T detail, CorrelationToken ct)
        {
            Raise(new WfStepFinished<T>(worker, detail, ct));
        }
    }
}