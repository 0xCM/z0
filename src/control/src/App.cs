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


    class App : AppShell<App,IAppContext>
    {                
        public App()
            : base(ContextFactory.CreateAppContext())
        {
            // Ct = CorrelationToken.define(1);
            // Sink = Flow.log(Context);
            // Config = Flow.LoadConfig(Context, Sink);            
            // Wf = WfContext.create(Context, Config, Sink);
        }
        
        // readonly CorrelationToken Ct;

        // readonly IMultiSink Sink;
        
        // readonly WfConfig Config;
        
        // readonly WfContext Wf;

        public override void RunShell(params string[] args)
        {                        
            using var control = new Controller(Context, args);
            control.Run();
            // var config = PartConfig(Wf, args);
            // var asm = AsmContext();
            // var cwf = capture(asm, CaptureRoot);
            // var broker = Broker();
            // using var host = new CaptureHost(Wf, asm, cwf, broker, config, Ct);
            // host.Run();

            // using var wf = new WfContext(Context, Flow.config(Context, Flow.TermReceiver), Flow.TermReceiver);
            // using var host = new CaptureHost(ContextFactory.CreateAsmContext(Context), PartWf.configure(wf, args));
            // host.Consolidate();
        }

        // static PartWfConfig PartConfig(WfContext wf, string[] args)
        //     => PartWf.configure(wf, args);

        // static ICaptureWorkflow capture(IAsmContext context, FolderPath target)
        // {
        //     var services = CaptureServices.create(context);
        //     var spec = AsmFormatSpec.DefaultStreamFormat;
        //     var formatter = services.Formatter(spec);
        //     var decoder = services.AsmDecoder(spec);
        //     var writer = Capture.Services.AsmWriterFactory;
        //     var archive = services.CaptureArchive(target);
        //     return new CaptureWorkflow(context, decoder, formatter, writer, archive);
        // }

        // IAsmContext AsmContext()
        //     => ContextFactory.CreateAsmContext(Context);
        
        // FolderPath CaptureRoot
        //     => Context.AppPaths.AppCaptureRoot;
        
        // FilePath CaptureLogPath
        //     => Context.AppPaths.AppDataRoot + FileName.Define("broker", FileExtensions.Csv);

        // ICaptureBroker Broker()
        //     => CaptureBroker.create(CaptureLogPath);
        
        

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend { }
}