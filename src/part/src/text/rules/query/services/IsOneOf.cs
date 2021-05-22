//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using T = TextQuery;

    partial struct SymbolicTests
    {
        [MethodImpl(Inline), Op]
        public static IsOneOf OneOfRule(params char[] src)
            => new IsOneOf(src);

        public readonly struct IsOneOf : ISymbolicQuery<IsOneOf,char>
        {
            readonly Index<char> Subjects;

            [MethodImpl(Inline), Op]
            public IsOneOf(char[] subjects)
                => Subjects = subjects;

            [MethodImpl(Inline)]
            public bit Check(char c)
                => T.contains(Subjects, c);
        }
    }
}