//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;

    partial class XTend
    {
        public static AsmServices AsmServices(this IWfShell wf)
            => Z0.Asm.AsmServices.create(wf);
    }

    [ApiHost]
    public readonly struct Capture
    {
        [Op]
        public static QuickCapture quick(IWfShell wf, IAsmContext asm)
        {
            var tokens = Buffers.sequence(asm.DefaultBufferLength, 5, out var buffer).Tokenize();
            var exchange = AsmServices.exchange(tokens[BufferSeqId.Aux3]);
            var proxy = new CaptureServiceProxy(asm.CaptureCore, exchange);
            return new QuickCapture(wf, asm, buffer, tokens, proxy);
        }

        [Op]
        public static void run(string[] args)
        {
            using var wf = configure(WfShell.create(args));
            var app = Apps.context(wf, Rng.@default());
            using var control = Capture.runner(wf, new AsmContext(app, wf));
            control.Run();
        }

        [Op]
        public static ApiCaptureRunner runner(IWfShell wf, IAsmContext asm)
            => new ApiCaptureRunner(wf, asm);

        [MethodImpl(Inline), Op]
        public static ICaptureServices services(IWfShell wf, IAsmContext asm)
            => new CaptureServices(wf, asm);

        [MethodImpl(Inline), Op]
        public static ICaptureCore core(IWfShell wf, IAsmContext asm)
            => CaptureCore.create(wf);

        [MethodImpl(Inline), Op]
        public static ApiCaptureEmitter emitter(IWfShell wf, IAsmContext asm)
            => new ApiCaptureEmitter(wf, asm);

        [MethodImpl(Inline), Op]
        public static CaptureAlt alt(IWfShell wf, IAsmContext asm)
            => CaptureAlt.create(wf);

        [Op]
        public static CaptureExchange exchange(IAsmContext context)
            => new CaptureExchange(new byte[context.DefaultBufferLength]);

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