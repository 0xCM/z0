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
        public static WfWarn<T> warn<T>(WfStepId step, T body, CorrelationToken ct)
            => new WfWarn<T>(step, body, ct);
    }
}