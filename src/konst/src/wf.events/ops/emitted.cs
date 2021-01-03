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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EmittingFileEvent<T> emittingFile<T>(WfStepId step, T src, FS.FilePath dst, CorrelationToken ct)
            => new EmittingFileEvent<T>(step, src, dst, ct);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EmittedFileEvent<T> emittedFile<T>(WfStepId step, T source, Count count, FS.FilePath dst, CorrelationToken ct)
            => new EmittedFileEvent<T>(step, source, count, dst, ct);

        [MethodImpl(Inline), Op]
        public static EmittedFileEvent emittedFile(WfStepId step, FS.FilePath path, Count segments, CorrelationToken ct)
            => new EmittedFileEvent(step, path, segments, ct);

        [MethodImpl(Inline), Op]
        public static EmittedFileEvent emittedFile(WfStepId step, FS.FilePath path, CorrelationToken ct)
            => new EmittedFileEvent(step, path, ct);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EmittingTableEvent<T> emittingTable<T>(WfStepId step, FS.FilePath dst, CorrelationToken ct)
            => new EmittingTableEvent<T>(step, dst, ct);

        [MethodImpl(Inline), Op]
        public static EmittingTableEvent emittingTable(WfStepId step, Type src, FS.FilePath dst, CorrelationToken ct)
            => new EmittingTableEvent(step, src, dst, ct);


        [MethodImpl(Inline), Op]
        public static EmittedTableEvent emittedTable(WfStepId step, TableId table, uint count, FS.FilePath dst, CorrelationToken ct)
            => new EmittedTableEvent(step, table, count, dst, ct);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EmittedTableEvent<T> emittedTable<T>(WfStepId step, Count count, FS.FilePath dst, CorrelationToken ct)
            where T : struct
                => new EmittedTableEvent<T>(step, count, dst, ct);
    }
}