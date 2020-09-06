//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;

    partial struct WfEvents
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ProcessedFile processed(WfStepId step, WfDataFlow<FS.FilePath> flow, uint size, CorrelationToken ct)
            => new ProcessedFile(step, flow, size, ct);

        [MethodImpl(Inline), Op]
        public static EmittedFile emitted(WfStepId step, FS.FilePath path, CorrelationToken ct)
            => new EmittedFile(step, path, ct);
    }
}