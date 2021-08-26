//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmEncoding
    {
        [MethodImpl(Inline), Op]
        public static Sib sib(uint3 @base, uint3 index, uint2 scale)
            => new Sib(Bits.join((scale, 0), (index, 2), (@base, 6)));
    }
}
