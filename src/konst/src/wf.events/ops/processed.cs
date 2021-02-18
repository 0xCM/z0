//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct WfEvents
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ProcessedEvent<T> processed<T>(WfStepId step, T content, CorrelationToken ct)
            => new ProcessedEvent<T>(step, content, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ProcessedFileEvent<T> processed<T>(WfStepId step, FS.FilePath src, T data, CorrelationToken ct)
            => new ProcessedFileEvent<T>(step, src, data, ct);

        [MethodImpl(Inline)]
        public static ProcessedFileEvent<T,M> processed<T,M>(WfStepId step, FS.FilePath src, T data, M metric, CorrelationToken ct)
            => new ProcessedFileEvent<T,M>(step, src, data, metric, ct);
    }
}