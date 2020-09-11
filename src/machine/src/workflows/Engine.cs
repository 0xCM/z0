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
                Run(new EmitMetadataSetsHost());
                Run(new CreateGlobalIndexHost());

            }
            catch(Exception e)
            {
                term.error(e);
            }

            Wf.Ran(StepId);
        }

        void Run(CreateGlobalIndexHost host)
        {
            Wf.Running(host.Id);
            using var step = new CreateGlobalIndex(Wf, host, State, new PartFiles(Wf, Wf.CaptureRoot));
            step.Run();
            Wf.Ran(host.Id);
        }

        public void Run(EmitMetadataSetsHost s)
        {
            Wf.Running(s.Id);
            using var step = new EmitMetadataSets(Wf);
            step.Run();
            Wf.Ran(s.Id);
        }

        void Run(ManageCaptureStep step, params string[] args)
        {
            using var control = WfCaptureControl.create(State);
            control.Run();
        }

        void Run(EmitDatasetsStep host)
        {
            Wf.Running(host.Id);

            try
            {
                using var emission = new EmitDatasets(Wf, host);
                emission.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran(host.Id);
        }

        void Run(ProcessPartFilesStep host)
        {
            Wf.Running(host.Id);

            try
            {
                using var step = new ProcessPartFiles(Wf, Asm, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran(host.Id);
        }
    }
}