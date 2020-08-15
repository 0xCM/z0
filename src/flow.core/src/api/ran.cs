//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial struct WfCore
    {
        [Op, Closures(UnsignedInts)]
        public static void ran<T>(IWfContext wf, string worker, T body, CorrelationToken ct)
            => wf.Raise(new WfStepRan<T>(worker, body, ct));
    }
}