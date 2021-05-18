//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static HexSymFacet;

    using XF = HexSymFacet;

    partial struct Hex
    {
        [MethodImpl(Inline), Op]
        public static HexDigit digit(char src)
        {
            if(number(src))
                return (HexDigit)((HexSymFacet)src - NumberOffset);
            else
            {
                if(test(UpperCase, src))
                    return (HexDigit)((XF)src - LetterOffsetUp);
                else
                    return (HexDigit)((XF)src - LetterOffsetLo);
            }
        }

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(LowerCased @case, char src)
            => number(src)
            ? (HexDigit)((XF)src - NumberOffset)
            : (HexDigit)((XF)src - LetterOffsetLo);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(UpperCased @case, char src)
            => number(src)
            ? (HexDigit)((XF)src - NumberOffset)
            : (HexDigit)((XF)src - LetterOffsetUp);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(HexSymLo src)
            => number(src)
            ? (HexDigit)((XF)src - NumberOffset)
            : (HexDigit)((XF)src - LetterOffsetLo);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by an uppercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(HexSymUp src)
            => number(src)
            ? (HexDigit)((XF)src - NumberOffset)
            : (HexDigit)((XF)src - LetterOffsetUp);
    }
}