//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct AB
    {
        [MethodImpl(Inline), Op]
        public static TermEventSink sink(CorrelationToken? ct = null)
            => new TermEventSink(correlate(ct));

        [MethodImpl(Inline), Op]
        public static WfTermEventSink sink(IWfEventLog log, CorrelationToken ct)
            => WfTermEventSink.create(log, ct);
    }
}