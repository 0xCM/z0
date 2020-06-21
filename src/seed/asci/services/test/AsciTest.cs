//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Konst;

    using UP = AsciLetterUp;
    using LO = AsciLetterLo;
    using HCL = HexCodeLo;
    using HCU = HexCodeUp;
    using HSL = HexSymLo;
    using HSLF = HexSymLoFacet;
    using HSU = HexSymUp;

    [ApiHost]
    public readonly struct AsciTest
    {
        /// <summary>
        /// Tests whether a character symbol is one of '0'..'9'
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool digit(char c)
            => (DeciSym)c >= DeciSym.First
            && (DeciSym)c <= DeciSym.Last;

        /// <summary>
        /// Tests whether a character is an uppercase asci letter character
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool letter(UpperCased @case, char c)
            => (ushort)c >= (ushort)UP.First  && (ushort)c <= (ushort)UP.Last;

        /// <summary>
        /// Tests whether a character is a lowercase asci letter character
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool letter(LowerCased @case, char c)
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
        public static bool IsNumeral(HSL src)
            => src <= (HSL)HSLF.LastNumeral;

        /// <summary>
        /// Tests whether a uppercas hex symbol is a numeral
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool IsNumeral(HSU src)
            => src <= HSU.LastNumeral;        

        /// <summary>
        /// Tests whether a lowercase hex symbol is a letter
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool IsLetter(HSL src)
            => src >= (HSL)HSLF.FirstLetter;

        /// <summary>
        /// Tests whether an uppercase hex symbol is a letter
        /// </summary>
        /// <param name="src">The symbol to test</param>
        [MethodImpl(Inline), Op]
        public static bool IsLetter(HSU src)
            => src >= HexSymUp.FirstLetter;
            
        /// <summary>
        /// Determines whether a character is an upper-cased hex digit
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool IsHexDigit(UpperCased casing, char c)
            => IsHexScalar(c) || IsHexUpper(c);

        /// <summary>
        /// Determines whether a character is a lower-cased hex digit
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool IsHexDigit(LowerCased casing, char c)
            => IsHexScalar(c) || IsHexLower(c);

        /// <summary>
        /// Determines whether a character is a hex digit of any case
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool IsHexDigit(char c)
            => IsHexScalar(c) || IsHexLower(c) || IsHexUpper(c);

        /// <summary>
        /// Determines whether a character corresponds to one of the lower hex codes
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        static bool IsHexScalar(char c)
            => (HCL)c >= HCL.FirstNumeral && (HCL)c <= HCL.LastNumeral;

        /// <summary>
        /// Determines whether a character corresponds to one of the uppercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        static bool IsHexUpper(char c)
            => (HCU)c >= HCU.FirstLetter && (HCU)c <= HCU.LastLetter;        

        /// <summary>
        /// Determines whether a character corresponds to one of the lowercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        static bool IsHexLower(char c)
            => (HCL)c >= HCL.FirstLetter && (HCL)c <= HCL.LastLetter;        

    }
}