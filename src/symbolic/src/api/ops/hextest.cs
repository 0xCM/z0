//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using HCL = HexCodeLo;
    using HCU = HexCodeUp;

    partial class Symbolic
    {
        /// <summary>
        /// Determines whether a character is an upper-cased hex digit
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool hextest(UpperCased casing, char c)
            => HexScalarTest(c) || HexUpperTest(c);

        /// <summary>
        /// Determines whether a character is a lower-cased hex digit
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool hextest(LowerCased casing, char c)
            => HexScalarTest(c) || HexLowerTest(c);

        /// <summary>
        /// Determines whether a character is a hex digit of any case
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool hextest(char c)
            => HexScalarTest(c) || HexLowerTest(c) || HexUpperTest(c);

        /// <summary>
        /// Determines whether a character corresponds to one of the lower hex codes
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        static bool HexScalarTest(char c)
            => (HCL)c >= HCL.FirstNumeral && (HCL)c <= HCL.LastNumeral;

        /// <summary>
        /// Determines whether a character corresponds to one of the uppercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        static bool HexUpperTest(char c)
            => (HCU)c >= HCU.FirstLetter && (HCU)c <= HCU.LastLetter;        

        /// <summary>
        /// Determines whether a character corresponds to one of the lowercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        static bool HexLowerTest(char c)
            => (HCL)c >= HCL.FirstLetter && (HCL)c <= HCL.LastLetter;        

    }
}