//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct AB
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void status<T>(IWfShell wf, string actor, T body, CorrelationToken ct)
            => wf.Raise(new WfStatus<T>(actor, body, ct));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void status<T>(IWfShell wf, WfStepId step, T body, CorrelationToken ct)
            => wf.Raise(new WfStatus<T>(step, body, ct));
    }
}