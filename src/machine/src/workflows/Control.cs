//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Konst;
    using static Controller;
    using static Shell;

    using static z;

    [ApiHost]
    public ref struct Control
    {
        readonly IAppContext Context;

        readonly IWfContext Wf;

        readonly WfCaptureState State;

        readonly IAsmContext Asm;

        readonly CorrelationToken Ct;

        readonly List<Instruction> Buffer;

        // public static Engine engine(WfCaptureState wf, CorrelationToken ct)
        // {
        //     wf.Initializing(StepId, ct);
        //     var step = default(Engine);
        //     try
        //     {
        //         step = new Engine(wf, ct);
        //         var client = step as IMachineEngine;
        //         client.Connect();
        //     }
        //     catch(Exception e)
        //     {
        //         wf.Error(Machines.StepName, e, ct);
        //         throw;
        //     }

        //     wf.Initialized(StepId, ct);
        //     return step;
        // }


        public Control(IWfContext wf)
        {
            Wf = wf;
            Buffer = list<Instruction>(2000);
            Ct = correlate(PartId.Machine);
            Context = wf.ContextRoot;
            Asm = AsmWfBuilder.asm(Context);
            State = new WfCaptureState(Wf, Asm, wf.Config, wf.Ct);
        }

        public void Run()
        {
            Run(default(ManageCaptureStep));
            Run(default(EmitDatasetsStep));
            Run(default(ProcessPartFilesStep));
            Run(default(Engines));
        }

        public void Dispose()
        {
            Wf.Finished(StepId);
        }

        void Run(ManageCaptureStep kind, params string[] args)
        {
            using var control = WfCaptureControl.create(State);
            control.Run();
        }

        void Run(EmitDatasetsStep kind)
        {
            Wf.Running(StepId, kind);
            try
            {
                using var emission = new EmitDatasets(Wf, Ct);
                emission.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }

            Wf.Ran(StepId, kind);
        }

        void Run(Engines kind)
        {
            // Wf.Running(StepId, kind);
            // try
            // {
            //     using var step = Engine.create(State, Ct);
            //     step.Run();
            // }
            // catch(Exception e)
            // {
            //     Wf.Error(e, Ct);
            // }

            // Wf.Ran(StepId, kind);
        }

        void Run(ProcessPartFilesStep kind)
        {
            Wf.Running(StepId, kind);

            try
            {
                using var step = new ProcessPartFiles(Wf, Asm, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }
            Wf.Ran(StepId, kind);
        }

    }
}