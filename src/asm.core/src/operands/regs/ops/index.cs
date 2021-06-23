//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmRegs
    {
        [MethodImpl(Inline), Op]
        public static RegWidthIndex index(RegWidth width)
            => (RegWidthIndex)Pow2.log((ushort)width);

        [MethodImpl(Inline), Op]
        public static RegIndex index(RegOp src)
            =>(RegIndex)Bits.segment(src.Bitfield, 10, 15);
    }
}
