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
        public static ProcessedFile processed(WfStepId step, WfDataFlow<FS.FilePath> flow, uint size, CorrelationToken ct)
            => new ProcessedFile(step, flow, size, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static Processed<T> processed<T>(WfStepId step, WfDataFlow<T> flow, CorrelationToken ct)
            => new Processed<T>(step,flow,ct);

        [MethodImpl(Inline)]
        public static Processed<S,T> processed<S,T>(WfStepId step, WfDataFlow<S,T> flow, CorrelationToken ct)
            => new Processed<S,T>(step,flow,ct);
    }
}