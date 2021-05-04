//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct SymbolicTests
    {
        /// <summary>
        /// Tests whether a character is one of (0,..9) | (a .. f) | (A .. F)
        /// </summary>
        public readonly struct IsHexDigit : ISymbolicTest<IsHexDigit,char>
        {
            [MethodImpl(Inline)]
            public bit Check(char c)
                => hex(c);
        }
    }
}