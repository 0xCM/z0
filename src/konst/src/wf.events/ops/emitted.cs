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
        public static EmittedFile emitted(WfStepId step, FS.FilePath path, CorrelationToken ct)
            => new EmittedFile(step, path, ct);

        [MethodImpl(Inline), Op]
        public static EmittedTable emitted(WfStepId step, TableId table, uint count, FS.FilePath dst, CorrelationToken ct)
            => new EmittedTable(step, table, count, dst, ct);
    }
}