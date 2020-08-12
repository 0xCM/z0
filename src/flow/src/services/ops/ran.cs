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
        [Op, Closures(UnsignedInts)]
        public static void ran<T>(IWfContext wf, string worker, T body, CorrelationToken ct)
            => wf.Raise(new WfStepRan<T>(worker, body, ct));

        [Op, Closures(UnsignedInts)]
        public static WfStepRan<T> ran<T>(string worker, T body, CorrelationToken ct)
            => new WfStepRan<T>(worker, body, ct);            
    }
}