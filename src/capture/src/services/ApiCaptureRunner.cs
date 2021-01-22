//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static z;

    public readonly struct ApiCaptureRunner : IDisposable
    {
        public static ApiCaptureRunner create(IWfShell wf, IAsmContext asm)
            => new ApiCaptureRunner(wf, asm, WfShell.host(typeof(ApiCaptureRunner)));

        public static void run(string[] args)
        {
            using var wf = Configure(WfShell.create(args));
            var app = Apps.context(wf, Rng.@default());
            using var control = create(wf, new AsmContext(app, wf));
            control.Run();
        }

        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        readonly IAppContext App;

        readonly PartId[] Parts;

        ApiCaptureRunner(IWfShell wf, IAsmContext asm, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            App = asm.ContextRoot;
            Asm = asm;
            Parts = Wf.Api.PartIdentities;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            using var flow = Wf.Running();
            Wf.Status(enclose(Wf.Api.PartIdentities));
            RunPrimary();
            RunImm();
            RunEvaluate();
            EmitDump();
        }

        void RunPrimary()
        {
            var flow = Wf.Running(nameof(ApiCaptureService));
            using var step = ApiCaptureService.create(Wf, Asm);
            step.Run();
            Wf.Ran(flow);
        }

        void RunImm()
        {
            var flow = Wf.Running(nameof(ImmClosureEmitter));
            using var step = new ImmClosureEmitter(Wf, Asm);
            step.ClearArchive(Parts);
            step.EmitRefined(Parts);
            Wf.Ran(flow);
        }

        void RunEvaluate()
        {
            var flow = Wf.Running(nameof(Evaluate));
            var evaluate = Evaluate.control(App, Wf.Paths.AppCaptureRoot, Pow2.T14);
            evaluate.Execute();
            Wf.Ran(flow);
        }

        void EmitDump()
        {
            var flow = Wf.Running("Emitting process dump");
            var process = Runtime.CurrentProcess;
            var name = process.ProcessName;
            var dst = Wf.Db().ProcDumpPath(name).EnsureParentExists();
            dst.Delete();
            DumpEmitter.emit(Runtime.CurrentProcess, dst.Name, DumpTypeOption.Full);
            Wf.Ran(flow, "Emitted process dump");
        }


        static IWfShell describe(IWfShell wf)
        {
            iter(wf.Settings, s => wf.Status(string.Format("{0}:{1}", s.Name, s.Value )));
            return wf;
        }

        static IWfShell Configure(IWfShell wf)
            => describe(wf.WithRandom(Rng.@default())
                 .WithHost(WfShell.host(typeof(ApiCaptureRunner)))
                 .WithVerbosity(LogLevel.Babble));

    }
}