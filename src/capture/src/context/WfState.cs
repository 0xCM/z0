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

    public readonly struct WfState
    {
        public WfContext Wf {get;}

        public IAppContext ContextRoot {get;}
        
        public IAsmContext Asm {get;}

        public ICaptureWorkflow CWf {get;}

        public WfConfig Config {get;}
        
        public AsmFormatSpec FormatConfig {get;}

        public AsmFormatter Formatter {get;}

        public TCaptureServices Services{get;}

        public IAsmFunctionDecoder FunctionDecoder {get;}
        
        readonly CorrelationToken Ct {get;}

        public ICaptureBroker Broker {get;}


        [MethodImpl(Inline)]
        public WfState(WfContext wf, IAsmContext asm, string[] args, CorrelationToken ct)        
        {
            Wf = wf;
            ContextRoot = wf.ContextRoot;
            Asm = asm;            
            Ct = ct;
            var parsed = AppArgs.parse(args).Data.Select(arg => PartIdParser.single(arg.Value)).ToArray();
            var srcpath = FilePath.Define(wf.GetType().Assembly.Location).FolderPath;
            var dstpath = wf.AppPaths.AppCaptureRoot;
            var src = new ArchiveConfig(srcpath);
            var dst = new ArchiveConfig(dstpath);
            Config = new WfConfig(args, src, dst, parsed);                    
            Services = CaptureServices.create(Asm);            
            FormatConfig = AsmFormatSpec.WithSectionDelimiter;
            Formatter = Services.Formatter(FormatConfig);            
            FunctionDecoder = Services.FunctionDecoder(FormatConfig); 
            CWf = new CaptureWorkflow(Asm, Wf, FunctionDecoder, Formatter, Services.AsmWriterFactory, Services.CaptureArchive(Config.Target), Ct);    
            Broker = CaptureBroker.create(FilePath.Empty, ct);
        }

        public ICaptureContext CaptureContext 
            => CWf.Context;

        public IAppEventSink AppEventSink 
            => CWf.Broker.Sink;
                
        public IWfEventSink WfEventSink
            => Wf.Broker.Sink;

        public void Created(string worker, CorrelationToken ct)
            => Wf.Created(worker, Ct);

        public void Running(string worker, CorrelationToken ct)
            => Wf.Running(worker, ct);

        public void Ran(string worker, CorrelationToken ct)
            => Wf.Ran(worker, Ct);

        public void Finished(string worker, CorrelationToken ct)
            => Wf.Finished(worker, Ct);

        public void Error(string worker, Exception e, CorrelationToken ct)
            => Wf.Error(worker, e, Ct);

        public void Error(string worker, string description, CorrelationToken ct)
            => Wf.Error(worker, description, ct);

        public void Status<T>(string worker, T body, CorrelationToken ct)
            => Wf.Status(worker, body, ct);

        public WfEventId Raise<E>(in E @event)
            where E : IWfEvent
                => Wf.Raise(@event);
    }
}