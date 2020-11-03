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
        public static RanEvent<T> ran<T>(WfStepId step, T content, CorrelationToken ct)
            => new RanEvent<T>(step, content, ct);

        [MethodImpl(Inline)]
        public static RanEvent<T> ran<H,T>(H host, T content, CorrelationToken ct)
            where H : IWfHost<H>, new()
                => new RanEvent<T>(host.Id, content, ct);

        [MethodImpl(Inline), Op]
        public static RanEvent ran(WfStepId step, CorrelationToken ct)
            => new RanEvent(step, ct);
    }
}