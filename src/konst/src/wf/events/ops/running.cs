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
        public static WfStepRunning running(WfActor actor, WfStepId step, CorrelationToken ct)
            => new WfStepRunning(step, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepRunning<T> running<T>(WfStepId step, T content, CorrelationToken ct)
            => new WfStepRunning<T>(step, content, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepRunning<T> running<S,T>(S step, T content, CorrelationToken ct)
            where S : struct, IWfStep<S>
                => new WfStepRunning<T>(step.Id, content, ct);

        [MethodImpl(Inline)]
        public static WfStepRunning<WfDataFlow<S,T>> running<S,T>(WfStepId step, WfDataFlow<S,T> flow, CorrelationToken ct)
            => new WfStepRunning<WfDataFlow<S,T>>(step, flow, ct);
    }
}