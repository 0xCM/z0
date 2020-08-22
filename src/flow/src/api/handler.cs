//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static ProcessFx;

    partial struct Flow    
    {
        [MethodImpl(Inline)]
        public static WfDataHandler<S,T> handler<S,T>(IWfContext wf, Map<S,T> f, S[] src, T[] dst)
            => new WfDataHandler<S,T>(wf, f,src,dst);
    }
}