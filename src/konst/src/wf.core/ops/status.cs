//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct WfCore
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void status<T>(IWfShell wf, WfStepId step, T body, CorrelationToken ct)
            => wf.Raise(new StatusEvent<T>(step, body, ct));
    }
}