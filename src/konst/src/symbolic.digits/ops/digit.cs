//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static HexConst;

    using B = BinaryDigit;
    using O = OctalDigit;
    using D = DecimalDigit;
    using X = HexDigit;

    using OC = OctalSym;
    using DS = DecimalSym;

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
        [MethodImpl(Inline), Op]
        static bit test(char c)
            => (DecimalSymFacet)c >= DecimalSymFacet.First && (DecimalSymFacet)c <= DF.Last;

        [MethodImpl(Inline), Op]
        public static B digit(BinarySym c)
            => (B)((BF)c - BF.First);

        [MethodImpl(Inline), Op]
        public static O digit(OC c)
            => (O)(c - OctalSym.First);

        [MethodImpl(Inline), Op]
        public static D digit(DS c)
            => (D)((DF)c - DF.First);

        [MethodImpl(Inline), Op]
        public static BinaryDigit digit(Base2 @base, char c)
            => (BinaryDigit)((BF)c - BF.First);

        [MethodImpl(Inline), Op]
        public static O digit(Base8 @base, char c)
            => (O)((OctalSym)c - OctalSym.First);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static X digit(Base16 @base, LowerCased @case, char src)
            => test(src)
            ? (X)((HexSymFacet)src - HexSymFacet.NumberOffset)
            : (X)((HexSymFacet)src - HexSymFacet.LetterOffsetLo);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static X digit(Base16 @base, UpperCased @case, char src)
            => test(src)
            ? (X)((HexSymFacet)src - HexSymFacet.NumberOffset)
            : (X)((HexSymFacet)src - HexSymFacet.LetterOffsetUp);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(HexSymLo src)
            => number(src)
            ? (X)((HexSymFacet)src - HexSymFacet.NumberOffset)
            : (X)((HexSymFacet)src - HexSymFacet.LetterOffsetLo);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by an uppercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(HexSymUp src)
            => number(src)
            ? (X)((HexSymFacet)src - HexSymFacet.NumberOffset)
            : (X)((HexSymFacet)src - HexSymFacet.LetterOffsetUp);

        [MethodImpl(Inline), Op]
        public static DecimalDigit digit(Base10 @base, char c)
            => (DecimalDigit)((DF)c - DF.First);

        /// <summary>
        /// Extracts an index-identified encoded digit
        /// </summary>
        /// <param name="base">The base selector</param>
        /// <param name="src">The digit source</param>
        /// <param name="index">An integer in the inclusive range [0, 1] that identifies the digit to extract</param>
        [MethodImpl(Inline), Op]
        public static DecimalDigit digit(Base10 @base, ushort src, byte index)
            => (DecimalDigit)(F & (src >> index*4));

        /// <summary>
        /// Extracts an index-identified encoded digit
        /// </summary>
        /// <param name="base">The base selector</param>
        /// <param name="src">The digit source</param>
        /// <param name="index">An integer in the inclusive range [0, 3] that identifies the digit to extract</param>
        [MethodImpl(Inline), Op]
        public static DecimalDigit digit(Base10 @base, uint src, byte index)
            => (DecimalDigit)(F & (src >> index*4));

        /// <summary>
        /// Extracts an index-identified encoded digit
        /// </summary>
        /// <param name="base">The base selector</param>
        /// <param name="src">The digit source</param>
        /// <param name="index">An integer in the inclusive range [0, 7] that identifies the digit to extract</param>
        [MethodImpl(Inline), Op]
        public static DecimalDigit digit(Base10 @base, ulong src, byte index)
            => (DecimalDigit)(F & (src >> index*4));
    }
}