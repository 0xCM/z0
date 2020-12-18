//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct GridCalcs
    {
        [MethodImpl(Inline)]
        public static GridStatsConverter<S,T> conversion<S,T>(uint srcCount)
            where S : struct
            where T : struct
                => new GridStatsConverter<S,T>(srcCount);
    }
}