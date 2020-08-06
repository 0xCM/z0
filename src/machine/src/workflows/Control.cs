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
    using static Controller;

    using static z;
    
    [ApiHost]
    public ref struct Control
    {        
        readonly IAppContext Context;

        readonly IAppPaths Paths;

        readonly WfContext Wf;

        readonly WfState State;
        
        readonly WfSettings Config;

        readonly IAsmContext Asm;

        readonly ActorIdentity[] Known;

        readonly string[] Args;
        
        readonly CorrelationToken Ct;        

        WorkflowStepConfig StepConfig;

        static ICaptureWorkflow capture(IAsmContext asm, WfContext wf, FolderPath target, CorrelationToken ct)
        {
            var services = CaptureServices.create(asm);
            var spec = AsmFormatSpec.DefaultStreamFormat;
            var formatter = services.Formatter(spec);
            var decoder = services.FunctionDecoder(spec);
            var writer = Capture.Services.AsmWriterFactory;
            var archive = services.CaptureArchive(target);
            return new CaptureWorkflow(asm, wf, decoder, formatter, writer, archive, ct);
        }

        public static Control create(IAppContext context, CorrelationToken ct, params string[] args)
        {
            var receiver = termsink(ct);
            var wf = Flow.context(context, ct, settings(context, ct), receiver);
            return new Control(context, ct, args);
        }

        public Control(IAppContext context, CorrelationToken ct, string[] args, params ActorIdentity[] known)
        {
            Context = context;
            Args = args;
            Ct = ct;
            Paths = context.AppPaths;
            Asm = WfBuilder.asm(context);                           
            Config = settings(context, Ct);
            Wf = Flow.context(context, Ct, Config, Flow.termsink(ct));                        
            State = new WfState(Wf, Asm, args, Ct);
            StepConfig = WorkflowStepConfig.Load(Wf);
            Known = known;
        }

        public void Run()
        {
            Wf.Running(WorkerName, Ct);
            Run(default(CaptureHostStep));
            Run(default(EmitDatasetsStep));
            Run(default(ProcessPartFilesStep));
        }

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }

        void Run(CaptureHostStep kind)
        {
            if(CaptureArtifacts)
            {             
                var cwf = capture(Asm, Wf, Context.AppPaths.AppCaptureRoot, Ct);
                var broker = WfBuilder.capture(Context.AppPaths.AppDataRoot + FileName.Define("broker", FileExtensions.Csv), Ct);
                var config = configure(Wf, Args);
                using var host = new CaptureClient(State, broker, config, Ct);
                host.Run();
            }
        }
        
        void Run(EmitDatasetsStep kind)
        {
            if(EmitDatasets)
            {
                Wf.RunningT(WorkerName, kind, Ct);
                try
                {
                    using var emission = new EmitDatasets(Wf, Ct, Args);
                    emission.Run();
                }
                catch(Exception e)
                {
                    Wf.Error(e, Ct);
                }

                Wf.RanT(WorkerName, kind, Ct);
            }
        }

        void Run(RunProcessorsStep kind)
        {
            Wf.RunningT(WorkerName, kind, Ct);
            try
            {
                using var step = RunProcessors.create(Wf, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }

            Wf.RanT(WorkerName, kind, Ct);
        }
        void Run(ProcessPartFilesStep kind)
        {
            Wf.RunningT(WorkerName, kind, Ct);
            
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
            
            Wf.RanT(WorkerName, kind, Ct);
        }
        
        bool CaptureArtifacts => true;
        
        bool EmitDatasets => true;
    }
}