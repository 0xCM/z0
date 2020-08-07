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
        [MethodImpl(Inline), Op]
        public static void warn<T>(IWfContext wf, string worker, T body, CorrelationToken ct)
            => wf.Raise(new WfWarn<T>(worker, body, ct));
    }
}