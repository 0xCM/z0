//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct SymbolicTests
    {
        public readonly struct IsWhitespace : ISymbolicTest<IsWhitespace,char>
        {
            public static bit check(char c)
                => IsSpace.check(c) || IsTab.check(c) || IsNewLine.check(c);

            [MethodImpl(Inline)]
            public bit Check(char c)
                => check(c);
        }
    }
}