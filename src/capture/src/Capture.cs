//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Root;
    using static Msg;

    [ApiHost]
    public readonly struct Capture
    {
        [Op]
        public static Index<AsmHostRoutines> run(string[] args)
        {
            var control = root.controller();
            var dir = FS.path(control.Location).FolderPath;
            var parts = ApiQuery.parts(control, args);
            var identities = parts.RuntimeCatalog.PartIdentities;
            using var wf = WfRuntime.create(parts, args);
            var runner = wf.CaptureRunner();
            var running = wf.Running(CapturingRoutines.Format(dir));
            var routines = args.Length != 0 ? runner.Capture(identities, CaptureWorkflowOptions.EmitImm) : runner.Capture(identities);
            var total = 0u;
            root.iter(routines, r => total += r.Count);
            wf.Ran(running, CapturedRoutines.Format(total,routines.Length));
            return routines;
        }

        [Op]
        public static Index<AsmHostRoutines> run(IWfRuntime wf, Index<PartId> parts, CaptureWorkflowOptions options)
            => wf.CaptureRunner().Capture(parts, options);

        [Op]
        public static Index<AsmHostRoutines> run(IWfRuntime wf, Index<ApiHostUri> parts, CaptureWorkflowOptions options)
            => wf.CaptureRunner().Capture(parts, options);

        [MethodImpl(Inline),Op]
        public static CaptureExchange exchange(byte[] buffer)
            => new CaptureExchange(buffer);
    }
}