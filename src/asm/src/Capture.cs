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
        public static QuickCapture quick(IWfRuntime wf)
        {
            var tokens = Buffers.alloc(Pow2.T16, 5, out var buffer).Tokenize();
            var exchange = AsmServices.exchange(tokens[BufferSeqId.Aux3]);
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
        public static Index<AsmMemberRoutine> run(string[] args)
        {
            var parts = ApiQuery.parts(root.controller(), args);
            var identities = parts.RuntimeCatalog.PartIdentities;
            using var wf = WfRuntime.create(parts, args);
            using var runner = wf.CaptureRunner();
            if(args.Length != 0)
                return runner.Capture(identities, CaptureWorkflowOptions.EmitImm);
            else
                return runner.Capture(identities);
        }

        [Op]
        public static CaptureExchange exchange(uint size = Pow2.T16)
            => new CaptureExchange(new byte[size]);
    }
}