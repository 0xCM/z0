//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static void running<T>(IWfContext wf, WfActor worker, T message, CorrelationToken ct)
            => wf.Raise(new WfStepRunning<T>(worker, message, ct));

        [MethodImpl(Inline), Op]
        public static WfStepRunning running(WfActor actor, WfStepId step, CorrelationToken ct)
            => new WfStepRunning(actor, step, ct);
    }
}