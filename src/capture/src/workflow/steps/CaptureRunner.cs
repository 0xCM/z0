//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Z0.Asm;

    using static z;

    public readonly struct CaptureRunner : IDisposable
    {
        public static CaptureRunner create(IWfShell wf, IAsmContext asm)
            => new CaptureRunner(wf, asm, WfShell.host(typeof(CaptureRunner)));

        public static void run(IWfShell wf, IAsmContext asm)
        {
            using var control = create(wf, asm);
            control.Run();
        }

        static IWfShell describe(IWfShell wf)
        {
            iter(wf.Settings, s => wf.Status(string.Format("{0}:{1}", s.Name, s.Value )));
            return wf;
        }

        static IWfShell Configure(IWfShell wf)
            => describe(wf.WithRandom(Rng.@default())
                 .WithHost(WfShell.host(typeof(CaptureRunner)))
                 .WithVerbosity(LogLevel.Babble));

        public static void run(IWfShell wf)
        {
            var app = Apps.context(wf);
            run(wf, new AsmContext(app, wf));
        }

        public static void run(string[] args)
        {
            using var wf = Configure(WfShell.create(args));
            run(wf);
        }

        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        readonly IAppContext App;

        readonly PartId[] Parts;

        public CaptureRunner(IWfShell wf, IAsmContext asm, WfHost host)
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
            EmitReports();
            //ManageCapture.create(Asm).Run(Wf);
        }

        void RunPrimary()
        {
            using var flow = Wf.Running(nameof(PartCaptureService));
            using var step = PartCaptureService.create(Wf, Asm);
            step.Run();
        }

        void RunImm()
        {
            using var flow = Wf.Running(nameof(EmitImmClosures));
            using var step = new EmitImmClosuresStep(Wf, new EmitImmClosures(), Asm, Asm.Formatter, Asm.RoutineDecoder, Wf.Db().CaptureRoot());
            step.ClearArchive(Parts);
            step.EmitRefined(Parts);
        }

        void RunEvaluate()
        {
            using var flow = Wf.Running(nameof(Evaluate));
            var evaluate = Evaluate.control(App, Wf.Paths.AppCaptureRoot, Pow2.T14);
            evaluate.Execute();
        }

        void EmitReports()
        {
            using var flow = Wf.Running(MethodInfo.GetCurrentMethod().Name);
            EmitCodeBlockReport.create().Run(Wf);
        }
    }
}