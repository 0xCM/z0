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

    [ApiHost]
    public readonly partial struct WfSinks
    {
        [MethodImpl(Inline), Op]
        public static TermEventSink term(CorrelationToken? ct = null)
            => new TermEventSink(correlate(ct));

        [MethodImpl(Inline), Op]
        public static WfTermEventSink term(IWfEventLog log, CorrelationToken ct)
            => WfTermEventSink.create(log, ct);
    }
}