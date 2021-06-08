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
        public static IsWhitespace WhitespaceRule()
            => default;

        public readonly struct IsWhitespace : ISymbolicQuery<IsWhitespace,char>
        {
            [MethodImpl(Inline)]
            public bit Check(char c)
                => T.whitespace(c);
        }
    }
}