//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct SymbolicTests
    {
        public readonly struct IsOneOf : ISymbolicTest<IsOneOf,char>
        {
            readonly Index<char> Subjects;

            [MethodImpl(Inline), Op]
            public IsOneOf(char[] subjects)
                => Subjects = subjects;

            [MethodImpl(Inline)]
            public bit Check(char c)
                => contains(Subjects, c);
        }
    }
}