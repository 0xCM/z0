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
        public static WfStepRunning running(WfStepId step, CorrelationToken ct)
            => new WfStepRunning(step, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepRunning<T> running<T>(WfStepId step, T content, CorrelationToken ct)
            => new WfStepRunning<T>(step, content, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepRunning<T> running<H,T>(H host, T content, CorrelationToken ct)
            where H : IWfHost<H>, new()
                => new WfStepRunning<T>(host.Id, content, ct);

        [MethodImpl(Inline)]
        public static WfStepRunning<DataFlow<S,T>> running<S,T>(WfStepId step, DataFlow<S,T> flow, CorrelationToken ct)
            => new WfStepRunning<DataFlow<S,T>>(step, flow, ct);
    }
}