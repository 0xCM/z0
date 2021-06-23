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
    public readonly partial struct AsmRegs
    {
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
        public static RegWidth width(RegOp src)
            => width((RegWidthIndex)(src.Bitfield & 0b111));

        [MethodImpl(Inline), Op]
        public static RegIndex regidx(RegOp src)
            =>(RegIndex)Bits.segment(src.Bitfield, 10, 15);

        [MethodImpl(Inline), Op]
        public static RegClass regclass(RegOp src)
            => (RegClass)Bits.segment(src.Bitfield, 5, 9);

        [Op]
        public static AsmRegQuery query()
            => new AsmRegQuery(Symbols.index<RegKind>());

        [Op]
        public static ReadOnlySpan<RegClass> classes()
            => Symbols.index<RegClass>().Kinds;

        [Op]
        public static string describe(Register src)
        {
            const string Sep = " | ";
            const string Pattern = "[{0,-12} | {1,-8} | {2}]";
            var index = Bitfields.format<RegIndex,byte>(src.Code, src.Name, 5);
            var @class = Bitfields.format<RegClass,byte>(src.Class, src.Class.ToString(), 4);
            var width = Enums.field<RegWidth,ushort>(src.Width, base10, "Width");
            return string.Format(Pattern, index, @class, width);
        }

        [MethodImpl(Inline), Op]
        public static bool valid(RegIndex src)
            => (uint)src <= 31;

        [MethodImpl(Inline), Op]
        public static bool invalid(RegIndex src)
            => (uint)src >= 32;

        [MethodImpl(Inline), Op]
        public static bool hi(Register r)
            => ((uint)r.Kind & RegFacets.Hi) != 0;

        [Op]
        public static ReadOnlySpan<Register> list()
        {
            var symbols = Symbols.index<RegKind>().View;
            return symbols.Map(from);
        }
    }
}