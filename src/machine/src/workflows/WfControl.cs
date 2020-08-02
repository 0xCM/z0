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

    [ApiHost]
    public ref struct WfControl
    {        
        readonly IAppContext Context;

        readonly WfContext Wf;
        
        readonly ActorIdentity[] Known;

        readonly string[] Args;
        
        readonly CorrelationToken Ct;

        static ICaptureWorkflow capture(IAsmContext context, FolderPath target)
        {
            var services = CaptureServices.create(context);
            var spec = AsmFormatSpec.DefaultStreamFormat;
            var formatter = services.Formatter(spec);
            var decoder = services.AsmDecoder(spec);
            var writer = Capture.Services.AsmWriterFactory;
            var archive = services.CaptureArchive(target);
            return new CaptureWorkflow(context, decoder, formatter, writer, archive);
        }

        public static void run(IAppContext context, params string[] args)
        {
            //using var receiver = Flow.log(context);
            var receiver = Flow.TermReceiver;
            using var wf = WfContext.create(context, Flow.LoadConfig(context, receiver), receiver);
            using var control = new WfControl(wf, args);
            control.Run();
        }

        [MethodImpl(Inline)]
        WfControl(WfContext wf, string[] args, params ActorIdentity[] known)     
        {
            Context = wf.ContextRoot;
            Wf = wf;
            Args = args;
            Known = known;
            Ct =  CorrelationToken.define(1ul);
        }

        public void Run()
        {
            Wf.Running(nameof(WfControl), Ct);

            if(CaptureArtifacts)
            {
                var asm = ContextFactory.CreateAsmContext(Context);
                var cwf = capture(asm, Context.AppPaths.AppCaptureRoot);
                var broker = CaptureBroker.create(Context.AppPaths.AppDataRoot + FileName.Define("broker", FileExtensions.Csv));
                var config = PartWf.configure(Wf, Args);
                using var host = new CaptureHost(Wf, asm, cwf, broker, config, Ct);
                host.Run();
            }

            if(EmitDatasets)
            {
                using var emission = new EmitDatasets(Wf, Args);
                emission.Run();
            }                    
        }

        public void Dispose()
        {
            Wf.Ran(nameof(WfControl), Ct);
        }

        bool CaptureArtifacts => false;
        
        bool EmitDatasets => true;
    }
}