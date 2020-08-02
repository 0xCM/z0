//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    using static Konst;

    using static z;

    readonly ref struct Controller
    {
        readonly IAppContext Context;

        readonly IAsmContext Asm;
        
        readonly string[] Args;

        readonly CorrelationToken Ct;

        readonly IMultiSink Sink;
        
        readonly WfConfig Config;
        
        readonly WfContext Wf;

        readonly TAppPaths Paths;

        public Controller(IAppContext context, string[] args)
        {
            Args = args;
            Context = context;
            Paths = context.AppPaths;
            Asm = ContextFactory.CreateAsmContext(context);                           
            Ct = CorrelationToken.define(1);
            Sink = Flow.log(context);
            Config = Flow.LoadConfig(context, Sink);            
            Wf = WfContext.create(context, Config, Sink);            
            Wf.Initialized(nameof(Controller), Ct);          
        }

        public void Run()
        {
            Wf.Running(nameof(Controller), Ct);
            var config = PartConfig(Wf, Args);
            var cwf = capture(Asm, Paths.AppCaptureRoot);
            var brokerLog = Paths.AppDataRoot + FileName.Define("broker", FileExtensions.Csv);
            var broker = CaptureBroker.create(brokerLog);
            using var host = new CaptureHost(Wf, Asm, cwf, broker, config, Ct);
            host.Run();
        }

        public void Dispose()
        {
            Wf.Ran(nameof(Controller), Ct);
        }

        static PartWfConfig PartConfig(WfContext wf, string[] args)
        {
            var parsed = AppArgs.parse(args).Data.Select(arg => PartIdParser.single(arg.Value));
            var srcpath = FilePath.Define(wf.GetType().Assembly.Location).FolderPath;
            var dstpath = wf.AppPaths.AppCaptureRoot;
            var src = new ArchiveConfig(srcpath);
            var dst = new ArchiveConfig(dstpath);
            return new PartWfConfig(wf, args, src, dst, parsed);                    
        }

        static ICaptureWorkflow capture(IAsmContext context, FolderPath dst)
        {
            var services = CaptureServices.create(context);
            var spec = AsmFormatSpec.DefaultStreamFormat;
            var formatter = services.Formatter(spec);
            var decoder = services.AsmDecoder(spec);
            var writer = Capture.Services.AsmWriterFactory;
            var archive = services.CaptureArchive(dst);
            return new CaptureWorkflow(context, decoder, formatter, writer, archive);
        }
    }
}