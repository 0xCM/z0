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
    using HSL = HexSymLo;
    using HSU = HexSymUp;

    partial struct AsciTest
    {
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