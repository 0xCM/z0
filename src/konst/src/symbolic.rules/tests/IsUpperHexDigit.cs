﻿//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;

    using XF = HexSymFacet;

    partial struct SymbolicTests
    {
        /// <summary>
        /// Tests whether a character is one of (0,..9) | (A .. F)
        /// </summary>
        public readonly struct IsUpperHexDigit : ISymbolicTest<IsUpperHexDigit,char>
        {
            [MethodImpl(Inline), Op]
            internal static bit check(XF src)
                => (src >= XF.FirstNumber && src <= XF.LastNumber) || (src >= XF.FirstLetterUp && src <= XF.LastLetterUp);

            [MethodImpl(Inline), Op]
            public static bit check(char src)
                => check((XF)(src));

            [MethodImpl(Inline)]
            public bit Check(char c)
                => check(c);
        }
    }
}