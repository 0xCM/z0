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
        public static FileEmitted emitted(WfStepId step, FS.FilePath path, Count segments, CorrelationToken ct)
            => new FileEmitted(step, path, segments, ct);

        [MethodImpl(Inline), Op]
        public static TableEmittedEvent emitted(WfStepId step, TableId table, uint count, FS.FilePath dst, CorrelationToken ct)
            => new TableEmittedEvent(step, table, count, dst, ct);
    }
}