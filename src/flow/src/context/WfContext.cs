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

    public struct WfContext : IWfContext<WfSettings>
    {        
        public const string ActorName = nameof(WfContext);
        
        public IAppContext ContextRoot {get;}
        
        public WfSettings State {get;}

        public IPart[] Parts {get;}

        public WfTermEventSink TermSink {get;}
                        
        public WfBroker Broker {get;}
                
        public FolderPath IndexRoot {get;}
        
        public FolderPath ResourceRoot {get;}
        
        public FilePath LogPath {get;}

        readonly CorrelationToken Ct;

        long CtProvider;

        readonly ulong SessionId;

        [MethodImpl(Inline)]
        public WfContext(IAppContext root, CorrelationToken ct, WfSettings config, WfTermEventSink sink)
        {
            Ct = ct;
            ContextRoot = root;
            State = config;
            TermSink = sink;
            SessionId = (ulong)now().Ticks;
            CtProvider = 1;       
            Parts = new IPart[0]{};
            ResourceRoot = ContextRoot.AppPaths.ResourceRoot;
            IndexRoot =  ResourceRoot + FolderName.Define("index");
            LogPath = root.AppPaths.AppDataRoot + FileName.Define("workflow", FileExtensions.Csv);
            Broker = new WfBroker(Ct);
            TermSink.Deposit(new OpeningWfContext(ActorName, typeof(WfContext).Name, Ct));
        }

        public void Dispose()
        {
            TermSink.Deposit(new ClosingWfContext(ActorName, typeof(WfContext).Name, Ct));
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
            Raise(error(msg,ct));
        }
        
        public void Error(string worker, Exception e, CorrelationToken ct)
        {
            Raise(new WfError<Exception>(worker, e, e, ct));
        }

        public void Emitting(string worker, string dsname, FilePath dst, CorrelationToken ct)
        {
            Raise(new EmittingDataset(worker, dsname, dst, ct));
        }

        public void Emitted(string worker, string dsname, uint count, FilePath dst, CorrelationToken ct)
        {
            Raise(new EmittedDataset(worker, dsname, count,  dst, ct));
        }

        public void Running(string worker, string detail, CorrelationToken ct)
        {
            Raise(new WfStepRunning(worker, detail, ct));
        }
        
        public void Running(string worker, CorrelationToken ct)
        {
            Raise(new WfStepRunning(worker, ct));
        }

        public void Status(string worker, string msg, CorrelationToken ct)
        {   
            Raise(new WfStatus(worker, msg, ct));            
        }

        public void Created(string worker, CorrelationToken ct)
        {   
            Raise(new WorkerCreated(worker, ct));            
        }

        public void Finished(string worker, CorrelationToken ct)
        {   
            Raise(new WorkerFinished(worker, ct));            
        }

        public void Initializing(string worker, CorrelationToken ct)
        {
            Raise(new WorkerInitializing(worker, ct));
        }

        public void Initialized(string worker, CorrelationToken ct)
        {
            Raise(new WorkerInitialized(worker, ct));
        }
        
        public void Ran(string worker, CorrelationToken ct)
        {
            Raise(new WfStepFinished(worker, ct));            
        }

        public void Ran(string worker, string detail, CorrelationToken ct)
        {
            Raise(new WfStepFinished(worker, detail, ct));
        }

        public void Status<T>(string worker, T body, CorrelationToken ct)
        {   
            Raise(status(worker, body, ct));
        }

        public void RunningT<T>(string worker, T detail, CorrelationToken ct)
        {
            Raise(new WfStepRunning<T>(worker, detail, ct));
        }
        
        public void RanT<T>(string worker, T detail, CorrelationToken ct)
        {
            Raise(new WfStepFinished<T>(worker, detail, ct));
        }

        public void Error<T>(string worker, T body, CorrelationToken ct)
        {
            Raise(new WfError(worker, body, ct));
        }
    }
}