//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct SymbolicTests
    {
        /// <summary>
        /// Tests whether a character is either a <see cref="AsciCharCode.CR"/> or <see cref="AsciCharCode.NL"/>
        /// </summary>
        public readonly struct IsNewLine : ISymbolicTest<IsWhitespace,char>
        {
            [MethodImpl(Inline)]
            public bit Check(char c)
                => newline(c);
        }
    }
}