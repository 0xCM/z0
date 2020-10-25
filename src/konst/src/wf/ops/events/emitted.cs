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
        public static EmittedFileEvent fileOut(WfStepId step, FS.FilePath path, Count segments, CorrelationToken ct)
            => new EmittedFileEvent(step, path, segments, ct);

        [MethodImpl(Inline), Op]
        public static EmittedTableEvent tableOut(WfStepId step, TableId table, uint count, FS.FilePath dst, CorrelationToken ct)
            => new EmittedTableEvent(step, table, count, dst, ct);

        [MethodImpl(Inline), Op]
        public static EmittedFileEvent<T> fileOut<T>(WfStepId step, T source, Count count, FS.FilePath dst, CorrelationToken ct)
            => new EmittedFileEvent<T>(step, source, count, dst, ct);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static EmittedTableEvent<T> tableOut<T>(WfStepId step, Count count, FS.FilePath dst, CorrelationToken ct)
            where T : struct
                => new EmittedTableEvent<T>(step, count, dst, ct);
    }
}