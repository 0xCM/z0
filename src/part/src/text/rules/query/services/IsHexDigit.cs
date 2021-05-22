//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    using T = TextQuery;

    partial struct SymbolicTests
    {
        [MethodImpl(Inline), Op]
        public static IsHexDigit HexDigitRule()
            => default;

        /// <summary>
        /// Tests whether a character is one of (0,..9) | (a .. f) | (A .. F)
        /// </summary>
        public readonly struct IsHexDigit : ISymbolicQuery<IsHexDigit,char>
        {
            [MethodImpl(Inline)]
            public bit Check(char c)
                => T.hex(c);
        }
    }
}