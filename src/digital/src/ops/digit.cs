//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static HexConst;

    using DF = DecimalSymFacet;
    using BF = BinarySymFacet;

    partial struct Digital
    {
        /// <summary>
        /// Converts a character in the inclusive range [0,9] to the corresponding number in the same range
        /// </summary>
        /// <param name="c">The digit character</param>
        [MethodImpl(Inline), Op]
        public static ulong digit(char c)
            => (ulong)c - (ulong)'0';

        /// <summary>
        /// Extracts an index-identified encoded digit
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="index">An integer in the inclusive range [0, 7] that identifies the digit to extract</param>
        [MethodImpl(Inline), Op]
        public static ulong digit(ulong src, byte index)
            => 0xF & (src >> index*4);

        /// <summary>
        /// Tests whether a character symbol is one of '0'..'9'
        /// </summary>
        /// <param name="src">The symbol to test</param>
        public static bit number(char c)
            => (DF)c >= DF.First && (DF)c <= DF.Last;

        [MethodImpl(Inline), Op]
        public static BinaryDigitValue digit(BinaryDigitSym s)
            => (BinaryDigitValue)((BF)s - BF.First);

        [MethodImpl(Inline), Op]
        public static OctalDigitValue digit(OctalDigitSym s)
            => (OctalDigitValue)(s - OctalDigitSym.o0);

        [MethodImpl(Inline), Op]
        public static DecimalDigitValue digit(DecimalDigitSym s)
            => (DecimalDigitValue)((DF)s - DF.First);

        [MethodImpl(Inline), Op]
        public static BinaryDigitValue digit(Base2 @base, char c)
            => (BinaryDigitValue)((BF)c - BF.First);

        [MethodImpl(Inline), Op]
        public static OctalDigitValue digit(Base8 @base, char c)
            => (OctalDigitValue)((OctalDigitSym)c - OctalDigitSym.o0);

        [MethodImpl(Inline), Op]
        public static HexDigitValue digit(Base16 @base, char src)
            => Hex.digit(src);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigitValue digit(Base16 @base, LowerCased @case, char src)
            => Hex.digit(@case, src);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigitValue digit(Base16 @base, UpperCased @case, char src)
            => Hex.digit(@case, src);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigitValue digit(HexLowerSym src)
            => Hex.digit(src);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by an uppercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigitValue digit(HexUpperSym src)
            => Hex.digit(src);

        [MethodImpl(Inline), Op]
        public static DecimalDigitValue digit(Base10 @base, char c)
            => (DecimalDigitValue)((DF)c - DF.First);

        /// <summary>
        /// Extracts an index-identified encoded digit
        /// </summary>
        /// <param name="base">The base selector</param>
        /// <param name="src">The digit source</param>
        /// <param name="index">An integer in the inclusive range [0, 1] that identifies the digit to extract</param>
        [MethodImpl(Inline), Op]
        public static DecimalDigitValue digit(Base10 @base, ushort src, byte index)
            => (DecimalDigitValue)(F & (src >> index*4));

        /// <summary>
        /// Extracts an index-identified encoded digit
        /// </summary>
        /// <param name="base">The base selector</param>
        /// <param name="src">The digit source</param>
        /// <param name="index">An integer in the inclusive range [0, 3] that identifies the digit to extract</param>
        [MethodImpl(Inline), Op]
        public static DecimalDigitValue digit(Base10 @base, uint src, byte index)
            => (DecimalDigitValue)(F & (src >> index*4));

        /// <summary>
        /// Extracts an index-identified encoded digit
        /// </summary>
        /// <param name="base">The base selector</param>
        /// <param name="src">The digit source</param>
        /// <param name="index">An integer in the inclusive range [0, 7] that identifies the digit to extract</param>
        [MethodImpl(Inline), Op]
        public static DecimalDigitValue digit(Base10 @base, ulong src, byte index)
            => (DecimalDigitValue)(F & (src >> index*4));
    }
}