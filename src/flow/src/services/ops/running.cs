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
        public static WfStepRunning<T> running<T>(string worker, T body, CorrelationToken ct)
            => new WfStepRunning<T>(worker, body, ct);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void running<T>(IWfContext wf, string worker, T body, CorrelationToken ct)
            => wf.Raise(new WfStepRunning<T>(worker, body, ct));
    }
}