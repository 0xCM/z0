//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static Konst;
    using static Shell;
    using static Engines;
    using static z;

    public class Engine : IDisposable
    {
        public static void run(IAppContext app, params string[] args)
        {
            try
            {
                var ct = correlate(ShellId);
                var config = WfBuilder.configure(app, args);
                using var log = Flow.log(config);
                using var wf = WfBuilder.shell(config, log);

                var state = new WfCaptureState(wf, AsmWfBuilder.asm(app), wf.Config, wf.Ct);
                wf.Running(StepId, delimit(config.Parts));
                using var machine = new Engine(state,ct);
                machine.Run();

                wf.Ran(StepId, ct);
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

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
            Wf.Finished(StepId, Ct);
        }


        IAsmContext Asm
            => State.Asm;

        public void Run()
        {
            Wf.Running(StepId);

            try
            {
                Run(default(ManageCaptureStep));
                Run(default(EmitDatasetsStep));
                Run(default(ProcessPartFilesStep));
                Run(default(EmitMetadataSetsStep));
                Run(default(CreateGlobalIndexStep));

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
            //var src = FS.dir((Wf.AppPaths.LogRoot + FolderName.Define("capture/artifacts")).Name);
            using var step = new CreateGlobalIndex(Wf, State, new PartFileProvider(Wf, Wf.CaptureRoot), Ct);
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