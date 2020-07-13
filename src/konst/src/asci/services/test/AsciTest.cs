//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    using XF = HexSymFacet;
    using DF = DecimalSymFacet;
    
    using UP = AsciLetterUp;
    using LO = AsciLetterLo;
    
    using HSL = HexSymLo;
    using HSU = HexSymUp;

    using UC = UpperCased;
    using LC = LowerCased;

    using AC = AsciCharCode;

    [ApiHost]
    public readonly struct AsciTest
    {
        /// <summary>
        /// Tests whether a character symbol is one of '0'..'9'
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool digit(char c)
            => (DF)c >= DF.First && (DF)c <= DF.Last;

        /// <summary>
        /// Tests whether a character is an uppercase asci letter character
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool letter(UC @case, char c)
            => (ushort)c >= (ushort)UP.First  && (ushort)c <= (ushort)UP.Last;

        /// <summary>
        /// Tests whether a character is a lowercase asci letter character
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool letter(LC @case, char c)
            => (ushort)c >= (ushort)LO.First  && (ushort)c <= (ushort)LO.Last;

        /// <summary>
        /// Tests whether a character is an asci letter character
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool letter(char c)
            => letter(UpperCase, c) || letter(LowerCase, c);

        /// <summary>
        /// Tests whether a lowercase hex symbol is a numeral
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool number(HSL src)
            => (XF)src <= XF.LastNumber;

        /// <summary>
        /// Tests whether a uppercas hex symbol is a numeral
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool number(HSU src)
            => (XF)src <= XF.LastNumber;

        /// <summary>
        /// Tests whether a lowercase hex symbol is a letter
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool letter(HSL src)
            => (XF)src >= XF.FirstLetterLo;

        /// <summary>
        /// Tests whether an uppercase hex symbol is a letter
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool letter(HSU src)
            => (XF)src >= XF.FirstLetterUp;
            
        /// <summary>
        /// Determines whether a character is an upper-cased hex digit
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool hex(UpperCased casing, char c)
            => IsHexScalar(c) || IsHexUpper(c);

        /// <summary>
        /// Determines whether a character is a lower-cased hex digit
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool hex(LowerCased casing, char c)
            => IsHexScalar(c) || IsHexLower(c);

        /// <summary>
        /// Determines whether a character is a hex digit of any case
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool hex(char c)
            => IsHexScalar(c) || IsHexLower(c) || IsHexUpper(c);

        /// <summary>
        /// Tests whether a character is a space
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool space(char c)
            => (ushort)AC.Space == (ushort)c;

        /// <summary>
        /// Tests whether a character is a space
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool tab(char c)
            => (ushort)AC.Tab == (ushort)c;

        [MethodImpl(Inline), Op]
        public static bool nl(char c)
            => (ushort)AC.NL == (ushort)c;

        [MethodImpl(Inline), Op]
        public static bool cr(char c)
            => (ushort)AC.CR == (ushort)c;

        [MethodImpl(Inline), Op]
        public static bool whitespace(char c)
            => space(c) || tab(c) || nl(c) || cr(c);

        /// <summary>
        /// Determines whether a character corresponds to one of the lower hex codes
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        static bool IsHexScalar(char c)
            => (XF)c >= XF.FirstNumber && (XF)c <= XF.LastNumber;

        /// <summary>
        /// Determines whether a character corresponds to one of the uppercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        static bool IsHexUpper(char c)
            => (XF)c >= XF.FirstLetterUp && (XF)c <= XF.LastLetterUp;        

        /// <summary>
        /// Determines whether a character corresponds to one of the lowercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        static bool IsHexLower(char c)
            => (XF)c >= XF.FirstLetterLo && (XF)c <= XF.LastLetterUp;        
    }
}