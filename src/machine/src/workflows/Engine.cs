//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static Konst;
    using static Engines;
    using static z;

    public class Engine : IDisposable
    {
        readonly WfCaptureState State;

        readonly CorrelationToken Ct;

        readonly IWfShell Wf;

        internal Engine(WfCaptureState state, CorrelationToken ct)
        {
            State = state;
            Wf = State.Wf;
            Ct = ct;
            Wf.Created(StepId, delimit(Wf.Api.PartIdentities));
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        IAsmContext Asm
            => State.Asm;

        public void Run()
        {
            Wf.Running(StepId);

            try
            {
                Run(new ManageCaptureStep());
                Run(new EmitDatasetsStep());
                Run(new ProcessPartFilesStep());
                Run(new EmitMetadataSetsStep());
                Run(new CreateGlobalIndexStep());

            }
            catch(Exception e)
            {
                term.error(e);
            }

            Wf.Ran(StepId);
        }

        void Run(CreateGlobalIndexStep s)
        {
            Wf.Running(s);
            using var step = new CreateGlobalIndex(Wf, State, new PartFiles(Wf, Wf.CaptureRoot));
            step.Run();
            Wf.Ran(s);
        }

        public void Run(EmitMetadataSetsStep s)
        {
            Wf.Running(s);
            using var step = new EmitMetadataSets(Wf);
            step.Run();
            Wf.Ran(s);
        }

        void Run(ManageCaptureStep step, params string[] args)
        {
            using var control = WfCaptureControl.create(State);
            control.Run();
        }

        void Run(EmitDatasetsStep step)
        {
            Wf.Running(StepId, step);

            try
            {
                using var emission = new EmitDatasets(Wf, Ct);
                emission.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }

            Wf.Ran(StepId, step);
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