//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static HexFormatSpecs;

    [ApiHost]
    public readonly struct HexDigitTest
    {
        /// <summary>
        /// Determines whether a specified character is a hex digit
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool test(char c)
            => scalar(c) || upper(c) || lower(c);

        /// <summary>
        /// Determines whether a character corresponds to one of the lower hex codes
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool scalar(char c)
            => (byte)c >= MinScalarCode && (byte)c <= MaxScalarCode;

        /// <summary>
        /// Determines whether a character corresponds to one of the uppercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool upper(char c)
            => (byte)c >= MinCharCodeU && (byte)c <= MaxCharCodeU;

        /// <summary>
        /// Determines whether a character corresponds to one of the lowercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool lower(char c)
            => (byte)c >= MinCharCodeL && (byte)c <= MaxCharCodeL;

        [MethodImpl(Inline), Op]
        public static HexDigitKind classify(char src)
        {
            var @class = HexDigitKind.None;
            if(scalar(src))
                return HexDigitKind.Number;
            else if(upper(src))
                return HexDigitKind.UpperLetter;
            else if(lower(src))
                return HexDigitKind.LowerLetter;
            else
                return 0;
        }
    }
}