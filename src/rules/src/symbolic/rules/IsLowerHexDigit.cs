//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct SymbolicRules
    {
        /// <summary>
        /// Tests whether a character is one of (0,..9) | (a .. f)
        /// </summary>
        public readonly struct IsLowerHexDigit : ISymbolQuery<IsHexDigit,char>
        {
            [MethodImpl(Inline)]
            public bit Test(char c)
                => SymbolicQuery.lowerhex(c);
        }
    }
}