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
            return new QuickCapture(wf, buffer, tokens, proxy);
        }

        [Op]
        public static Index<AsmMemberRoutine> run(IWfShell wf, Index<PartId> parts, CaptureWorkflowOptions options)
        {
            using var runner = wf.CaptureRunner();
            return runner.Capture(parts, options);
        }

        [Op]
        public static Index<AsmMemberRoutines> run(IWfShell wf, Index<ApiHostUri> parts, CaptureWorkflowOptions options)
        {
            using var runner = wf.CaptureRunner();
            return runner.Capture(parts, options);
        }

        [Op]
        public static Index<AsmMemberRoutine> run(IWfShell wf, PartId part)
        {
            using var runner = wf.CaptureRunner();
            return runner.Capture(part);
        }

        [Op]
        public static Index<AsmMemberRoutine> run(string[] args)
        {
            using var wf = WfShell.create(ApiCatalogs.parts(root.controller(), args), args);
            using var runner = wf.CaptureRunner();

            if(args.Length != 0)
                return runner.Capture(wf.Api.PartIdentities, CaptureWorkflowOptions.EmitImm);
            else
                return runner.Run();
        }

        [MethodImpl(Inline), Op]
        public static CaptureAlt alt(IWfShell wf, IAsmContext asm)
            => CaptureAlt.create(wf);

        [Op]
        public static CaptureExchange exchange(IAsmContext context)
            => new CaptureExchange(new byte[context.DefaultBufferLength]);
    }
}