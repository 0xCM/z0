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

        public static void run(IWfShell wf)
        {
            var app = Apps.context(wf, Rng.@default());
            run(wf, new AsmContext(app, wf));
        }

        public static void run(string[] args)
        {
            using var wf = Configure(WfShell.create(args));
            run(wf);
            dump(wf);
        }

        static void dump(IWfShell wf)
        {
            var flow = wf.Running("Emitting process dump");
            var process = Processes.current();
            var name = process.ProcessName;
            var dst = wf.Db().ProcDumpPath(name).EnsureParentExists();
            // var root = FS.dir(@"k:\dumps");
            // var dst =  root + FS.file(name.Content, FileExtensions.Dmp);
            //var dst = FS.path(@"k:\dumps\run\run.dmp");
            dst.Delete();
            DumpEmitter.emit(Processes.current(), dst.Name, DumpTypeOption.Full);
            wf.Ran(flow, "Emitted process dump");
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
            EmitReports();
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
            var flow = Wf.Running(nameof(EmitImmClosures));
            using var step = new EmitImmClosuresStep(Wf, new EmitImmClosures(), Asm, Asm.Formatter, Asm.RoutineDecoder, Wf.Db().CaptureRoot());
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

        void EmitReports()
        {
            //var flow = Wf.Running(MethodInfo.GetCurrentMethod().Name);
            //EmitCodeBlockReport.create().Run(Wf);
            //Wf.Ran(flow);
        }

        static void run(IWfShell wf, IAsmContext asm)
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
                 .WithHost(WfShell.host(typeof(ApiCaptureRunner)))
                 .WithVerbosity(LogLevel.Babble));

    }
}