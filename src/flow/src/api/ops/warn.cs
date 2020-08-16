//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct OldFlow    
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static WfWarn<T> warn<T>(string worker, T body, CorrelationToken ct)
            => new WfWarn<T>(worker, body, ct);       
        
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void warn<T>(IWfContext wf, string worker, T body, CorrelationToken ct)
            => wf.Raise(warn(worker,body,ct));
    }
}