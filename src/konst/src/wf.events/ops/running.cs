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
        [MethodImpl(Inline), Op]
        public static RunningEvent running(WfStepId step, CorrelationToken ct)
            => new RunningEvent(step, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static RunningEvent<T> running<T>(WfStepId step, T content, CorrelationToken ct)
            => new RunningEvent<T>(step, content, ct);

        [MethodImpl(Inline)]
        public static RunningEvent<T> running<H,T>(H host, T content, CorrelationToken ct)
            where H : IWfHost<H>, new()
                => new RunningEvent<T>(host.Id, content, ct);

        [MethodImpl(Inline)]
        public static RunningEvent<DataFlow<S,T>> running<S,T>(WfStepId step, DataFlow<S,T> flow, CorrelationToken ct)
            => new RunningEvent<DataFlow<S,T>>(step, flow, ct);
    }
}