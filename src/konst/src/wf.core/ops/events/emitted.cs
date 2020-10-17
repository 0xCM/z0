//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct WfEvents
    {
        [MethodImpl(Inline), Op]
        public static EmittedFileEvent emitted(WfStepId step, FS.FilePath path, Count segments, CorrelationToken ct)
            => new EmittedFileEvent(step, path, segments, ct);

        [MethodImpl(Inline), Op]
        public static EmittedTableEvent emitted(WfStepId step, TableId table, uint count, FS.FilePath dst, CorrelationToken ct)
            => new EmittedTableEvent(step, table, count, dst, ct);
    }
}