//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    using XF = HexSymFacet;

    [ApiHost]
    public readonly partial struct SymbolicTests
    {
        [MethodImpl(Inline)]
        public static bool test<T,S>(S symbol, T test = default)
            where S : unmanaged
            where T : unmanaged, ISymbolicTest<T,S>
                => test.Check(symbol);

        [MethodImpl(Inline), Op]
        public static bit whitespace(char c)
            => space(c) || tab(c) || newline(c);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit contains<T>(ReadOnlySpan<T> src, T match)
            where T : unmanaged, IEquatable<T>
        {
            var count = src.Length;
            if(count == 0)
                return false;

            for(var i=0u; i<count; i++)
                if(skip(src,i).Equals(match))
                    return true;

            return false;
        }

        [MethodImpl(Inline), Op]
        public static bit contains(SymbolRange<char> range, char src)
            => src >= range.Min && src <= range.Max;

        [MethodImpl(Inline), Op]
        public static bit hex(char src)
            => lowerhex(src) || upperhex(src);

        [MethodImpl(Inline), Op]
        public static bit @decimal(char c)
            => (DecimalSymFacet)c >= DecimalSymFacet.First && (DecimalSymFacet)c <= DecimalSymFacet.Last;

        [MethodImpl(Inline), Op]
        public static bit lowerhex(char src)
            => ((XF)src >= XF.FirstNumber && (XF)src <= XF.LastNumber)
            || ((XF)src >= XF.FirstLetterLo && (XF)src <= XF.LastLetterLo);


        [MethodImpl(Inline), Op]
        public static bit upperhex(char src)
            => ((XF)src >= XF.FirstNumber && (XF)src <= XF.LastNumber)
            || ((XF)src >= XF.FirstLetterUp && (XF)src <= XF.LastLetterUp);


        [MethodImpl(Inline), Op]
        public static bit newline(char c)
            => (ushort)AsciCharCode.NL == (ushort)c
            || (ushort)AsciCharCode.CR == (ushort)c;


        [MethodImpl(Inline), Op]
        public static bit tab(char c)
            => (ushort)AsciCharCode.Tab == (ushort)c;
    }
}