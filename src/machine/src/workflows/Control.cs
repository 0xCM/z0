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
    using static Controller;

    using static z;
    
    [ApiHost]
    public ref struct Control
    {        
        public static void run(IAppContext context, params string[] args)
        {
            var ct = CorrelationToken.define(1);
            var config = Flow.configure(context, args, ct);
            using var wf = Flow.context(context, config, ct);
            using var control = new Control(wf);
            control.Run();
        }

        readonly IAppContext Context;

        readonly IWfContext Wf;

        readonly WfState State;        

        readonly IAsmContext Asm;        

        WorkflowStepConfig StepConfig;

        static ICaptureWorkflow capture(IAsmContext asm, IWfContext wf, FolderPath target, CorrelationToken ct)
        {
            var services = CaptureServices.create(asm);
            var spec = AsmFormatSpec.DefaultStreamFormat;
            var formatter = services.Formatter(spec);
            var decoder = services.FunctionDecoder(spec);
            var writer = Capture.Services.AsmWriterFactory;
            var archive = services.CaptureArchive(target);
            return new CaptureWorkflow(asm, wf, decoder, formatter, writer, archive, ct);
        }

        public Control(WfContext wf)
        {
            Wf = wf;
            Context = wf.ContextRoot;
            Asm = WfBuilder.asm(Context);                           
            State = new WfState(Wf, Asm, wf.Config, wf.Ct);
            StepConfig = WorkflowStepConfig.Load(Wf);
        }

        CorrelationToken Ct 
            => Wf.Ct;        

        public void Run()
        {
            Wf.Running(WorkerName, Ct);
            Run(default(CaptureClientStep));
            Run(default(EmitDatasetsStep));
            Run(default(ProcessPartFilesStep));
            Run(default(RunProcessorsStep));
        }

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }

        void Run(CaptureClientStep kind)
        {
            var cwf = capture(Asm, Wf, Context.AppPaths.AppCaptureRoot, Ct);
            var broker = WfBuilder.capture(Context.AppPaths.AppDataRoot + FileName.Define("broker", FileExtensions.Csv), Ct);
            using var host = new CaptureClient(State, Ct);
            host.Run();
        }
        
        void Run(EmitDatasetsStep kind)
        {
            Wf.RunningT(WorkerName, kind, Ct);
            try
            {
                using var emission = new EmitDatasets(Wf, Ct);
                emission.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }

            Wf.RanT(WorkerName, kind, Ct);
        }

        void Run(RunProcessorsStep kind)
        {
            Wf.RunningT(WorkerName, kind, Ct);
            try
            {
                using var step = RunProcessors.create(State, Ct);
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
    }
}