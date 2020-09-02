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
        public static WfProcessingFile<T> processing<T>(string actor, T kind, FilePath src, CorrelationToken ct)
            => new WfProcessingFile<T>(actor, kind, src, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfProcessedFile<T> processed<T>(string actor, T kind, FilePath src, uint size, CorrelationToken ct)
            => new WfProcessedFile<T>(actor, kind, src, size, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfProcessedFile<T> processed<T>(WfStepId step, T content, WfDataFlow<FS.FilePath> flow, uint size, CorrelationToken ct)
            => new WfProcessedFile<T>(step, content, flow, size, ct);
    }
}