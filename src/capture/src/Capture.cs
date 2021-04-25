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

    [ApiHost]
    public readonly struct Capture
    {
        [Op]
        public static IAsmContext context(IWfRuntime wf)
            => new AsmContext(Apps.context(wf), wf);

        [MethodImpl(Inline), Op]
        public static ICaptureExchange exchange(BufferToken capture)
            => new CaptureExchangeProxy(capture);

        [Op]
        public static Index<AsmMemberRoutine> run(string[] args)
        {
            var control = root.controller();
            var dir = FS.path(control.Location).FolderPath;
            var parts = ApiQuery.parts(control, args);
            var identities = parts.RuntimeCatalog.PartIdentities;
            using var wf = WfRuntime.create(parts, args);
            using var runner = wf.CaptureRunner();

            var running = wf.Running(string.Format("Capturing routines from components in {0}", dir.Format(PathSeparator.FS)));
            var routines = args.Length != 0 ? runner.Capture(identities, CaptureWorkflowOptions.EmitImm) : runner.Capture(identities);
            wf.Ran(running, string.Format("Captured {0} routines", routines.Length));

            return routines;
        }

        [Op]
        public static QuickCapture quick(IWfRuntime wf)
        {
            var tokens = memory.alloc(Pow2.T16, 5, out var buffer).Tokenize();
            var exchange = Capture.exchange(tokens[BufferSeqId.Aux3]);
            var proxy = new CaptureServiceProxy(wf.CaptureCore(), exchange);
            return new QuickCapture(wf, buffer, tokens, proxy);
        }

        [Op]
        public static Index<AsmMemberRoutine> run(IWfRuntime wf, Index<PartId> parts, CaptureWorkflowOptions options)
        {
            using var runner = wf.CaptureRunner();
            return runner.Capture(parts, options);
        }

        [Op]
        public static Index<AsmHostRoutines> run(IWfRuntime wf, Index<ApiHostUri> parts, CaptureWorkflowOptions options)
        {
            using var runner = wf.CaptureRunner();
            return runner.Capture(parts, options);
        }

        [Op]
        public static Index<AsmMemberRoutine> run(IWfRuntime wf, PartId part)
        {
            using var runner = wf.CaptureRunner();
            return runner.Capture(part);
        }

        [Op]
        public static CaptureExchange exchange(uint size = Pow2.T16)
            => new CaptureExchange(new byte[size]);

        [MethodImpl(Inline),Op]
        public static CaptureExchange exchange(byte[] buffer)
            => new CaptureExchange(buffer);
    }
}