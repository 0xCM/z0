//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static RexPrefixFacets;

    [ApiHost]
    public readonly partial struct AsmQuery
    {
        [MethodImpl(Inline), Op]
        public static bit IsRexPrefix(byte src)
            => emath.between(src, MinRex, MaxRex);
    }
}