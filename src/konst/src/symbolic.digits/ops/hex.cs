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

    using XF = HexSymFacet;

    partial struct Digital
    {
        [MethodImpl(Inline), Op]
        public static HexSymLo hex(LowerCased casing, byte index)
            => skip(HexCharData.LowerSymbols, index);

        [MethodImpl(Inline), Op]
        public static HexSymUp hex(UpperCased casing, byte index)
            => skip(HexCharData.UpperSymbols, index);

        [MethodImpl(Inline), Op]
        public static HexSym hex(LowerCased @case, HexDigit src)
            => src <= HexDigit.x9
                ? (HexSym)((byte)src + (byte)HexSymFacet.FirstNumber)
                : (HexSym)((byte)src + (byte)HexSymFacet.FirstLetterLo);

        [MethodImpl(Inline), Op]
        public static HexSym hex(UpperCased @case, HexDigit src)
            => src <= HexDigit.x9
                ? (HexSym)((byte)src + (byte)HexSymFacet.FirstNumber)
                : (HexSym)((byte)src + (byte)HexSymFacet.FirstLetterUp);

        [MethodImpl(Inline), Op]
        public static char hexchar(LowerCased @case, byte index)
            => (char)Symbolic.symbol(@case, (HexDigit)index);

        /// <summary>
        /// Tests whether a lowercase hex symbol is a numeral
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool number(HexSymLo src)
            => (XF)src <= XF.LastNumber;

        /// <summary>
        /// Tests whether a uppercase hex symbol is a numeral
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool number(HexSymUp src)
            => (XF)src <= XF.LastNumber;

        /// <summary>
        /// Tests whether a lowercase hex symbol is a letter
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool hex(HexSymLo src)
            => (XF)src >= XF.FirstLetterLo;

        /// <summary>
        /// Tests whether an uppercase hex symbol is a letter
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool hex(HexSymUp src)
            => (XF)src >= XF.FirstLetterUp;

        /// <summary>
        /// Determines whether a character is an upper-cased hex digit
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool hex(UpperCased casing, char c)
            => hexscalar(c) || hexupper(c);

        /// <summary>
        /// Determines whether a character is a lower-cased hex digit
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool hex(LowerCased casing, char c)
            => hexscalar(c) || hexlower(c);

        /// <summary>
        /// Determines whether a character is a hex digit of any case
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool hext(char c)
            => hexscalar(c) || hexlower(c) || hexupper(c);

        /// <summary>
        /// Determines whether a character is one of [0..9]
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        public static bool hexscalar(char c)
            => (XF)c >= XF.FirstNumber && (XF)c <= XF.LastNumber;

        /// <summary>
        /// Determines whether a character corresponds to one of the uppercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        public static bool hexupper(char c)
            => (XF)c >= XF.FirstLetterUp && (XF)c <= XF.LastLetterUp;

        /// <summary>
        /// Determines whether a character corresponds to one of the lowercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        public static bool hexlower(char c)
            => (XF)c >= XF.FirstLetterLo && (XF)c <= XF.LastLetterUp;
    }
}