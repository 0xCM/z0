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
    public readonly struct AB
    {
        /// <summary>
        /// Creates a workflow event identifier
        /// </summary>
        /// <param name="name">The event name</param>
        /// <param name="ct">The correlation token, if any</param>
        /// <param name="ts">The timestamp which, if unspecified, will default to the event creation time (now)</param>
        [MethodImpl(Inline), Op]
        public static WfEventId id(string name, CorrelationToken? ct = null, Timestamp? ts = null)
            => new WfEventId(name, ct ?? correlate(0ul), ts ?? now());

        [MethodImpl(Inline), Op]
        public static TermEventSink sink(CorrelationToken? ct = null)
            => new TermEventSink(correlate(ct));

        [MethodImpl(Inline), Op]
        public static WfTermEventSink sink(IWfEventLog log, CorrelationToken ct)
            => WfTermEventSink.create(log, ct);


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static WfDataHandler<T> handler<T>(DataReceiver<T> receiver)
            => new WfDataHandler<T>(receiver);

    }
}