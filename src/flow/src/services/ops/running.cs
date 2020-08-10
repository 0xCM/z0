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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static WfStepRunning<T> running<T>(WfActor actor, T message, CorrelationToken ct)
            => new WfStepRunning<T>(actor, message, ct);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void running<T>(IWfContext wf, WfActor worker, T message, CorrelationToken ct)
            => wf.Raise(new WfStepRunning<T>(worker, message, ct));
    }
}