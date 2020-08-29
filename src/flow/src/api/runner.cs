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
        [MethodImpl(Inline)]
        public static WfRunner<A> runner<A>(IWfContext wf, Action<A> handler, A? args = null)
            where A : struct
                => new WfRunner<A>(wf, handler, args);

    }
}