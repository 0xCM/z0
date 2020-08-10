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
            var ct = CorrelationToken.define(PartId.Machine);
            var config = Flow.configure(context, args, ct);            
            using var wf = Flow.context(context, config, ct);
            wf.RunningT(nameof(Control), Flow.delimit(config.Parts), ct);
            using var control = new Control(wf);
            control.Run();
            wf.Ran(nameof(Control), ct);
        }

        readonly IAppContext Context;

        readonly IWfContext Wf;

        readonly WfState State;        

        readonly IAsmContext Asm;        

        WorkflowStepConfig StepConfig;

        readonly CorrelationToken Ct;

        public Control(IWfContext wf)
        {
            Wf = wf;
            Ct = CorrelationToken.define(PartId.Machine);
            Context = wf.ContextRoot;
            Asm = WfBuilder.asm(Context);                           
            State = new WfState(Wf, Asm, wf.Config, wf.Ct);
            StepConfig = WorkflowStepConfig.Load(Wf);
        }
            
        public void Run()
        {
            Wf.Running(ActorName, Ct);
            Run(default(CaptureClientStep));
            Run(default(EmitDatasetsStep));
            Run(default(ProcessPartFilesStep));
            Run(default(RunProcessorsStep));
        }

        public void Dispose()
        {
            Wf.Finished(ActorName, Ct);
        }

        void Run(CaptureClientStep kind, params string[] args)
        {
            using var control = CaptureController.create(Context, args, Ct);
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
                using var step = RunProcessors.create(State, Ct);
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