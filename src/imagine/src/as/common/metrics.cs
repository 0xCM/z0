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
        public static ConversionMetrics<S,T> metrics<S,T>(uint srcCount)
            where S : struct
            where T : struct
                => ConversionMetrics.define<S,T>(srcCount);
    }
}