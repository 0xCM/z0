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
        public static Index<AsmMemberRoutine> run(IWfShell wf, Index<PartId> parts, CaptureWorkflowOptions options)
        {
            using var runner = wf.CaptureRunner();
            return runner.Run(parts,options);
        }

        [Op]
        public static Index<AsmMemberRoutine> run(IWfShell wf, PartId part)
        {
            using var runner = wf.CaptureRunner();
            return runner.Run(part);
        }

        [Op]
        public static void run(string[] args)
        {
            using var wf = configure(WfShell.create(args));
            using var runner = wf.CaptureRunner();
            runner.Run();
        }

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