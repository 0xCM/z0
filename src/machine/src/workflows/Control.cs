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
            try
            {
                var ct = CorrelationToken.from(PartId.Machine);
                var paths = context.AppPaths;
                var config = Flow.configure(context, args, paths.ResourceRoot + FolderName.Define("capture"), ct);
                using var log = Flow.log(config);
                using var wf = Flow.context(context, config, log, ct);
                wf.RunningT(ActorName, Flow.delimit(config.Parts), ct);            
                using var control = new Control(wf);
                control.Run();
                wf.Ran(ActorName, ct);            
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        readonly IAppContext Context;

        readonly IWfContext Wf;

        readonly WfCaptureState State;        

        readonly IAsmContext Asm;        

        WorkflowStepConfig StepConfig;

        readonly CorrelationToken Ct;

        public Control(IWfContext wf)
        {
            Wf = wf;
            Ct = CorrelationToken.from(PartId.Machine);
            Context = wf.ContextRoot;
            Asm = WfBuilder.asm(Context);                           
            State = new WfCaptureState(Wf, Asm, wf.Config, wf.Ct);
            StepConfig = WorkflowStepConfig.load(Wf);
        }
            
        public void Run()
        {
            Run(default(CaptureClientStep));
            Run(default(EmitDatasetsStep));
            Run(default(ProcessPartFilesStep));
            Run(default(RunProcessorsStep));
        }

        public void Dispose()
        {
            
        }

        void Run(CaptureClientStep kind, params string[] args)
        {
            using var control = WfCaptureControl.create(State);
            control.Run();                        
        }
        
        void Run(EmitDatasetsStep kind)
        {
            Wf.RunningT(ActorName, kind, Ct);
            try
            {
                using var emission = new EmitDatasets(Wf, Ct);
                emission.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }

            Wf.RanT(ActorName, kind, Ct);
        }

        void Run(RunProcessorsStep kind)
        {
            Wf.RunningT(ActorName, kind, Ct);
            try
            {
                using var step = Engine.create(State, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }

            Wf.RanT(ActorName, kind, Ct);
        }
        
        void Run(ProcessPartFilesStep kind)
        {
            Wf.RunningT(ActorName, kind, Ct);
            
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
            
            Wf.RanT(ActorName, kind, Ct);
        }
    }
}