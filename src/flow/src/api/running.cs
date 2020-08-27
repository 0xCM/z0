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
        public static void running<T>(IWfContext wf, WfStepId step, T message, CorrelationToken ct)
            => wf.Raise(new WfStepRunning<T>(step, message, ct));
    }
}