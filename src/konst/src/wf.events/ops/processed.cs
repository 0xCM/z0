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
        public static ProcessedEvent<T> processed<T>(WfStepId step, DataFlow<T> flow, CorrelationToken ct)
            => new ProcessedEvent<T>(step,flow,ct);

        [MethodImpl(Inline)]
        public static ProcessedEvent<S,T> processed<S,T>(WfStepId step, DataFlow<S,T> flow, CorrelationToken ct)
            => new ProcessedEvent<S,T>(step,flow,ct);
    }
}