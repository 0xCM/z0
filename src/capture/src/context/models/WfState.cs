//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static Flow;
        
    public readonly struct WfState : IWfState
    {
        public IWfContext Wf {get;}

        public IAppContext ContextRoot {get;}
        
        public IAsmContext Asm {get;}

        public ICaptureWorkflow CWf {get;}
        
        public CaptureConfig Settings {get;}

        public WfConfig Config {get;}
        
        public AsmFormatSpec FormatConfig {get;}

        public AsmFormatter Formatter {get;}

        public TCaptureServices Services{get;}

        public IAsmFunctionDecoder FunctionDecoder {get;}
        
        public CorrelationToken Ct {get;}

        public ICaptureBroker CaptureBroker {get;}

        [MethodImpl(Inline)]
        public WfState(IWfContext wf, IAsmContext asm, WfConfig config, CorrelationToken ct)        
        {
            Wf = wf;
            ContextRoot = wf.ContextRoot;
            Asm = asm;            
            Ct = ct;
            Config = config;        
            var srcpath = FilePath.Define(wf.GetType().Assembly.Location).FolderPath;
            var dstpath = wf.AppPaths.AppCaptureRoot;
            var src = new ArchiveConfig(srcpath);
            var dst = new ArchiveConfig(dstpath);
            Settings = CaptureConfig.From(wf.ContextRoot.Settings);                             
            Services = CaptureServices.create(Asm);            
            FormatConfig = AsmFormatSpec.WithSectionDelimiter;
            Formatter = Services.Formatter(FormatConfig);            
            FunctionDecoder = Services.FunctionDecoder(FormatConfig); 
            CWf = new CaptureWorkflow(Asm, Wf, FunctionDecoder, Formatter, Services.AsmWriterFactory, Services.CaptureArchive(Config.Target), Ct);    
            CaptureBroker = WfBuilder.capture(FilePath.Empty, ct);
        }

        public ICaptureContext CaptureContext 
            => CWf.Context;

        public IAppEventSink AppEventSink 
            => CWf.Broker.Sink;
                
        public IWfEventSink WfEventSink
            => Wf.Broker.Sink;

        public void Created(string actor, CorrelationToken ct)
            => Wf.Created(actor, Ct);

        public void Running(string actor, CorrelationToken ct)
            => Wf.Running(actor, ct);

        public void Running<T>(string actor, T message, CorrelationToken ct)
            => Wf.RunningT(actor, message, ct);

        public void Ran<T>(string actor, T content, CorrelationToken ct)
            => Wf.RanT(actor, content, ct);

        public void Ran(string actor, CorrelationToken ct)
            => Wf.Ran(actor, Ct);

        public void Finished(string actor, CorrelationToken ct)
            => Wf.Finished(actor, Ct);

        public void Initializing(string actor, CorrelationToken ct)
            => Wf.Initializing(actor, Ct);

        public void Initialized(string actor, CorrelationToken ct)
            => Wf.Initialized(actor, Ct);

        public void Error(string actor, Exception e, CorrelationToken ct)
            => Wf.Error(actor, e, Ct);

        public void Error(string actor, string message, CorrelationToken ct)
            => Wf.Error(actor, message, ct);

        public void Status<T>(string actor, T mesage, CorrelationToken ct)
            => Wf.Status(actor, mesage, ct);

        public WfEventId Raise<E>(in E @event)
            where E : IWfEvent
                => Wf.Raise(@event);

        public void Dispose()
        {

            
        }                
    }
}