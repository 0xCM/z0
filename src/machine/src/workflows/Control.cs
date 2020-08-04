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
    using static WfControlStep;

    using static z;
    
    [ApiHost]
    public ref struct Control
    {        
        readonly IAppContext Context;

        readonly WfContext Wf;
        
        readonly IAsmContext Asm;

        readonly ActorIdentity[] Known;

        readonly string[] Args;
        
        readonly CorrelationToken Ct;

        readonly bool RunProcessPartFilesStep;

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

        public static Control create(IAppContext context, CorrelationToken ct, params string[] args)
        {
            var receiver = termsink(ct);
            var wf = wfctx(context, ct, wfconfig(context, receiver, ct), receiver);
            return new Control(wf, ct, args);
        }

        [MethodImpl(Inline)]
        Control(WfContext wf, CorrelationToken ct, string[] args, params ActorIdentity[] known)     
        {
            Context = wf.ContextRoot;
            Wf = wf;
            Args = args;
            Known = known;
            Ct =  ct;
            Asm = ContextFactory.asm(Context);
            RunProcessPartFilesStep = true;
        }

        void Run(CaptureHostStep kind)
        {
            if(CaptureArtifacts)
            {             
                var cwf = capture(Asm, Wf, Context.AppPaths.AppCaptureRoot);
                var broker = CaptureBroker.create(Context.AppPaths.AppDataRoot + FileName.Define("broker", FileExtensions.Csv), Ct);
                var config = wfconfig(Wf, Args);
                using var host = new CaptureHost(Wf, Asm, cwf, broker, config, Ct);
                host.Run();
            }
        }
        
        public void Run()
        {
            Wf.Running(WorkerName, Ct);
            Run(default(CaptureHostStep));

            if(EmitDatasets)
            {
                using var emission = new EmitDatasets(Wf, Ct, Args);
                emission.Run();
            } 

            if(RunProcessPartFilesStep)                   
            {
                Run(default(ProcessPartFilesStep));
            }
        }

        void Run(ProcessPartFilesStep kind)
        {
            try
            {
                var files = new PartFiles(Asm);
                using var step = new ProcessPartFiles(Wf, Asm, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }
        }
        
        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }

        bool CaptureArtifacts => false;
        
        bool EmitDatasets => true;

        bool RunMachine => true;
    }
}