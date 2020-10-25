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
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ProcessedEvent<T> processed<T>(WfStepId step, T content, CorrelationToken ct)
            => new ProcessedEvent<T>(step, content, ct);

        [MethodImpl(Inline)]
        public static ProcessedEvent<S,T> processed<S,T>(WfStepId step, DataFlow<S,T> flow, CorrelationToken ct)
            => new ProcessedEvent<S,T>(step,flow,ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ProcessedFileEvent<T> fileProcessed<T>(WfStepId step, FS.FilePath src, T kind, CorrelationToken ct)
            => new ProcessedFileEvent<T>(step, src, kind, ct);

        [MethodImpl(Inline)]
        public static ProcessedFileEvent<T,M> fileProcessed<T,M>(WfStepId step, FS.FilePath src, T kind, M metric, CorrelationToken ct)
            => new ProcessedFileEvent<T,M>(step, src, kind, metric, ct);

    }
}