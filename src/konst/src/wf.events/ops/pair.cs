//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct WfEvents
    {
        [MethodImpl(Inline)]
        public static WfEventPair<S,T> pair<S,T>(in S a, in T b)
            where S : struct, IWfEvent<S>
            where T : struct, IWfEvent<T>
                => new WfEventPair<S,T>(a,b);
    }
}