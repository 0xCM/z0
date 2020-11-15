//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;

    using AC = AsciCharCode;

    partial struct SymbolicTests
    {
        /// <summary>
        /// Tests whether a character is either a <see cref="AC.CR"/> or <see cref="AC.NL"/>
        /// </summary>
        public readonly struct IsNewLine : ISymbolicTest<IsWhitespace,char>
        {
            [MethodImpl(Inline)]
            public static bit check(char c)
                => (ushort)AC.NL == (ushort)c || (ushort)AC.CR == (ushort)c;

            [MethodImpl(Inline)]
            public bit Check(char c)
                => check(c);
        }
    }
}