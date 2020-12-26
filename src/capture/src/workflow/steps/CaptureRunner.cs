//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

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

        public CaptureRunner(IWfShell wf, IAsmContext asm, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Asm = asm;
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
            ManageCapture.create(Asm).Run(Wf);
        }
    }
}