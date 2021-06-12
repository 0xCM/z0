//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct SymbolicRules
    {
        public readonly struct IsOneOf : ISymbolQuery<IsOneOf,char>
        {
            readonly Index<char> Subjects;

            [MethodImpl(Inline), Op]
            public IsOneOf(char[] subjects)
                => Subjects = subjects;

            [MethodImpl(Inline)]
            public bit Test(char c)
                => SymbolicQuery.contains(Subjects, c);
        }
    }
}