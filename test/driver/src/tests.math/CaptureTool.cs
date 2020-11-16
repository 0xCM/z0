//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Asm;

    using static z;

    public readonly struct CaptureTool
    {
        static IWfShell describe(IWfShell wf)
        {
            iter(wf.Settings, s => wf.Status(string.Format("{0}:{1}", s.Name, s.Value )));
            return wf;
        }

        static IWfShell Configure(IWfShell wf)
            => describe(
                wf.WithRandom(Rng.@default())
                  .WithHost(WfShell.host(typeof(TestDriver)))
                  .WithVerbosity(LogLevel.Babble)
                );

        public static void run(string[] args)
        {
            using var wf = Configure(WfShell.create(args));
            var app = Apps.context(wf);
            var asm = new AsmContext(app, wf);
            var cstate = new WfCaptureState(wf, asm);
            using var control = CaptureWorkflow.create(cstate);
            control.Run();
        }

        public static void run(IWfShell wf)
        {
            var app = Apps.context(wf);
            var asm = new AsmContext(app, wf);
            var cstate = new WfCaptureState(wf, asm);
            using var control = CaptureWorkflow.create(cstate);
            control.Run();
        }
    }

}