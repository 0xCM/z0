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
        [MethodImpl(Inline), Op]
        public static IsWhitespace WhitespaceRule()
            => default;

        /// <summary>
        /// Tests whether a character is one of (0,..9)
        /// </summary>
        public readonly struct IsDecimalDigit : ISymbolQuery<IsDecimalDigit,char>
        {
            [MethodImpl(Inline)]
            public bit Test(char c)
                => SymbolicQuery.@decimal(c);
        }

        public readonly struct IsWhitespace : ISymbolQuery<IsWhitespace,char>
        {
            [MethodImpl(Inline)]
            public bit Test(char c)
                => SymbolicQuery.whitespace(c);
        }
    }
}