//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly partial struct AsmRegs
    {
        [Op]
        public static AsmRegQuery query()
            => new AsmRegQuery(Symbols.index<RegKind>());

        [Op]
        public static ReadOnlySpan<RegClass> classes()
            => Symbols.index<RegClass>().Kinds;

        [Op]
        public static string format(Register src)
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

        // [Op]
        // public static Index<Register> list()
        //     => Enums.literals<RegKind>().Map(from);
    }
}