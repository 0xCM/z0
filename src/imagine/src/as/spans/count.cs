//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct As
    {
        [MethodImpl(Inline)]
        internal static int count<S,T>(int srcCount)
            where S : struct
            where T : struct
                => TargetCount.define<S,T>(srcCount).DstCount;
    }
}