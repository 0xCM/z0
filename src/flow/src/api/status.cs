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
        public static void status<T>(IWfContext wf, string actor, T body, CorrelationToken ct)
            => wf.Raise(new WfStatus<T>(actor, body, ct));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void status<T>(IWfContext wf, WfStepId step, T body, CorrelationToken ct)
            => wf.Raise(new WfStatus<T>(step, body, ct));
    }
}