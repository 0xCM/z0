//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOpTypes;
    using static math;

    partial struct asm
    {
        [MethodImpl(Inline)]
        public static RegOp<T> reg<T>(T src)
            where T : unmanaged, IRegOp
                => new RegOp<T>(src);

        [MethodImpl(Inline), Op]
        public static RegOp reg(RegWidth width, RegClass @class, RegIndex r)
            => new RegOp(or((byte)index(width), sll((ushort)@class, 5), sll((ushort)r, 10)));

        [MethodImpl(Inline), Op]
        public static RegWidthIndex index(RegWidth width)
            => (RegWidthIndex)Pow2.log((ushort)width);

        [MethodImpl(Inline), Op]
        public static RegWidth width(RegWidthIndex wi)
            => (RegWidth)Pow2.pow((byte)wi);

        [MethodImpl(Inline), Op]
        public static RegWidth regwidth(RegOp src)
            => width((RegWidthIndex)(src.Bitfield & 0b111));

        [MethodImpl(Inline), Op]
        public static RegIndex regidx(RegOp src)
            =>(RegIndex)Bits.bitseg(src.Bitfield, 10, 15);

        [MethodImpl(Inline), Op]
        public static RegClass regclass(RegOp src)
            => (RegClass)Bits.bitseg(src.Bitfield, 5, 9);
    }
}