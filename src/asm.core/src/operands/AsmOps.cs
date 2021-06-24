//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static math;

    [ApiHost]
    public readonly partial struct AsmOps
    {
        [MethodImpl(Inline), Op]
        public static RegOp reg(RegWidth width, RegClass @class, RegIndex r)
            => new RegOp(or((byte)index(width), sll((ushort)@class, 5), sll((ushort)r, 10)));

        [MethodImpl(Inline), Op]
        public static RegOp reg(RegWidthIndex width, RegClass @class, RegIndex r)
            => new RegOp(or((byte)width, sll((ushort)@class, 5), sll((ushort)r, 10)));

        [MethodImpl(Inline), Op]
        public static RegWidthIndex index(RegWidth width)
            => (RegWidthIndex)Pow2.log((ushort)width);

        [MethodImpl(Inline), Op]
        public static RegIndex index(RegOp src)
            =>(RegIndex)Bits.segment(src.Bitfield, 10, 15);
    }
}