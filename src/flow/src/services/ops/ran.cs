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
        public static void ran<T>(IWfContext wf, string worker, T body, CorrelationToken ct)
            => wf.Raise(new WfStepFinished<T>(worker, body, ct));

        [MethodImpl(Inline), Op]
        public static WfStepFinished<T> ran<T>(string worker, T body, CorrelationToken ct)
            => new WfStepFinished<T>(worker, body, ct);            
    }
}