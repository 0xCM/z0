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
        public static IsNewLine NewLineRule()
            => default;

        /// <summary>
        /// Tests whether a character is either a <see cref="AsciCharCode.CR"/> or <see cref="AsciCharCode.LF"/>
        /// </summary>
        public readonly struct IsNewLine : ISymbolicQuery<IsNewLine,char>
        {
            [MethodImpl(Inline)]
            public bit Check(char c)
                => T.newline(c);
        }
    }
}