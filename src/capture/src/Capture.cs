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
        public static Index<AsmHostRoutines> run(string[] args)
        {
            var control = root.controller();
            var dir = FS.path(control.Location).FolderPath;
            var parts = ApiQuery.parts(control, args);
            var identities = parts.RuntimeCatalog.PartIdentities;
            using var wf = WfRuntime.create(parts, args);
            var runner = wf.CaptureRunner();
            var running = wf.Running(string.Format("Capturing routines from components in {0}", dir.Format(PathSeparator.FS)));
            var routines = args.Length != 0 ? runner.Capture(identities, CaptureWorkflowOptions.EmitImm) : runner.Capture(identities);
            wf.Ran(running, string.Format("Captured {0} routines", routines.Length));

            return routines;
        }

        [Op]
        public static Index<AsmHostRoutines> run(IWfRuntime wf, Index<PartId> parts, CaptureWorkflowOptions options)
        {
            var runner = wf.CaptureRunner();
            return runner.Capture(parts, options);
        }

        [Op]
        public static Index<AsmHostRoutines> run(IWfRuntime wf, Index<ApiHostUri> parts, CaptureWorkflowOptions options)
        {
            var runner = wf.CaptureRunner();
            return runner.Capture(parts, options);
        }

        [MethodImpl(Inline),Op]
        public static CaptureExchange exchange(byte[] buffer)
            => new CaptureExchange(buffer);
    }
}