//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using Z0.Asm;

    public readonly struct Capture
    {
        public static ICaptureServices Services
            => default(CaptureServices);

        public static ICaptureCore core()
            => default(CaptureCore);

        [Op]
        public static ICaptureAlt alt(IWfShell wf, IAsmContext asm)
            => default(CaptureAltService);

        [MethodImpl(Inline)]
        public static CaptureExchange exchange(IAsmContext context)
            => new CaptureExchange(context.CaptureCore, new byte[context.DefaultBufferLength]);

        public static ApiCaptureRunner runner(IWfShell wf, IAsmContext asm)
            => new ApiCaptureRunner(wf, asm, WfShell.host(typeof(ApiCaptureRunner)));

        public static void run(string[] args)
        {
            using var wf = configure(WfShell.create(args));
            var app = Apps.context(wf, Rng.@default());
            using var control = Capture.runner(wf, new AsmContext(app, wf));
            control.Run();
        }

        static IWfShell describe(IWfShell wf)
        {
            root.iter(wf.Settings, s => wf.Status(string.Format("{0}:{1}", s.Name, s.Value )));
            return wf;
        }

        static IWfShell configure(IWfShell wf)
            => describe(wf.WithRandom(Rng.@default())
                 .WithHost(WfShell.host(typeof(ApiCaptureRunner)))
                 .WithVerbosity(LogLevel.Babble));
    }
}