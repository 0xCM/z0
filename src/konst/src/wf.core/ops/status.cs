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

    partial struct Flow
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void status<T>(IWfShell wf, WfStepId step, T body, CorrelationToken ct)
            => wf.Raise(new WfStatus<T>(step, body, ct));
    }
}