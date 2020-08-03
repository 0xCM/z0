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

    [ApiHost]
    public ref struct WfControl
    {        
        readonly IAppContext Context;

        readonly WfContext Wf;
        
        readonly IAsmContext Asm;
        readonly ActorIdentity[] Known;

        readonly string[] Args;
        
        readonly CorrelationToken Ct;

        static ICaptureWorkflow capture(IAsmContext asm, WfContext wf, FolderPath target)
        {
            var services = CaptureServices.create(asm);
            var spec = AsmFormatSpec.DefaultStreamFormat;
            var formatter = services.Formatter(spec);
            var decoder = services.AsmDecoder(spec);
            var writer = Capture.Services.AsmWriterFactory;
            var archive = services.CaptureArchive(target);
            return new CaptureWorkflow(asm, wf, decoder, formatter, writer, archive);
        }

        public static WfControl create(IAppContext context, CorrelationToken? ct, params string[] args)
        {
            var _ct = correlate(ct);
            var receiver = termsink(_ct);
            var wf = wfctx(context, _ct, wfconfig(context, receiver), receiver);
            return new WfControl(wf, _ct, args);
        }

        [MethodImpl(Inline)]
        WfControl(WfContext wf, CorrelationToken ct, string[] args, params ActorIdentity[] known)     
        {
            Context = wf.ContextRoot;
            Wf = wf;
            Args = args;
            Known = known;
            Ct =  ct;
            Asm = ContextFactory.CreateAsmContext(Context);
        }

        public void Run()
        {
            Wf.Running(nameof(WfControl), Ct);

            if(CaptureArtifacts)
            {
             
                var cwf = capture(Asm, Wf, Context.AppPaths.AppCaptureRoot);
                var broker = CaptureBroker.create(Context.AppPaths.AppDataRoot + FileName.Define("broker", FileExtensions.Csv));
                var config = wfconfig(Wf, Args);
                using var host = new CaptureHost(Wf, Asm, cwf, broker, config, Ct);
                host.Run();
            }

            if(EmitDatasets)
            {
                using var emission = new EmitDatasets(Wf, Ct, Args);
                emission.Run();
            } 

            if(RunMachine)                   
            {
                //var ctx = MachineAsmContext.Create(Asm,)
            }
        }

        public void Dispose()
        {
            Wf.Ran(nameof(WfControl), Ct);
        }

        bool CaptureArtifacts => false;
        
        bool EmitDatasets => false;

        bool RunMachine => true;
    }
}