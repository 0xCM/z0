//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Hex
    {
        [MethodImpl(Inline), Op]
        public static bool test(char c)
            => isNumber(c) || isUpper(c) || isLower(c);

        /// <summary>
        /// Determines whether a character corresponds to one of the lower hex codes
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool isNumber(char c)
            => (byte)c >= MinScalarCode && (byte)c <= MaxScalarCode;

        /// <summary>
        /// Determines whether a character corresponds to one of the uppercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool isUpper(char c)
            => (byte)c >= MinCharCodeU && (byte)c <= MaxCharCodeU;        

        /// <summary>
        /// Determines whether a character corresponds to one of the lowercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool isLower(char c)
            => (byte)c >= MinCharCodeL && (byte)c <= MaxCharCodeL;        
    }
}