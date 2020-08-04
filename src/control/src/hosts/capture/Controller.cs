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
    using static Flow;

    using static z;

    readonly ref struct Controller
    {
        readonly IAppContext Context;

        readonly IAsmContext Asm;
        
        readonly string[] Args;

        readonly CorrelationToken Ct;
        
        readonly WfTermEventSink TermSink;

        readonly WfConfig Config;
        
        readonly WfContext Wf;

        readonly TAppPaths Paths;

        public Controller(IAppContext context, CorrelationToken ct, string[] args)
        {
            Context = context;
            Args = args;
            Ct = ct;
            TermSink = termsink(Ct);
            Paths = context.AppPaths;
            Asm = ContextFactory.asm(context);                           
            Config = wfconfig(context, wflog(context, Ct), Ct);            
            Wf = wfctx(context, Ct, Config, TermSink);                        
        }

        public void Run()
        {
            Wf.Running(nameof(Controller), Ct);
            var config = PartConfig(Wf, Args);
            var cwf = capture(Asm, Paths.AppCaptureRoot);
            var data = Paths.AppDataRoot + FolderName.Define("data");
            var brokerLog = (data + FileName.Define("broker", FileExtensions.Csv)).CreateParentIfMissing();
            var cBroker = CaptureBroker.create(brokerLog, Ct);
            
            using var host = new CaptureHost(Wf, Asm, cwf, cBroker, config, Ct);
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

        ICaptureWorkflow capture(IAsmContext context, FolderPath dst)
        {
            var services = CaptureServices.create(context);
            var spec = AsmFormatSpec.DefaultStreamFormat;
            var formatter = services.Formatter(spec);
            var decoder = services.AsmDecoder(spec);
            var writer = Capture.Services.AsmWriterFactory;
            var archive = services.CaptureArchive(dst);
            return new CaptureWorkflow(context, Wf, decoder, formatter, writer, archive);
        }
    }
}