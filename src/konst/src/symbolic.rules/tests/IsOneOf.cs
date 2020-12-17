//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct SymbolicTests
    {
        public readonly struct IsOneOf : ISymbolicTest<IsOneOf,char>
        {
            readonly Index<char> Subjects;

            [MethodImpl(Inline), Op]
            public IsOneOf(char[] subjects)
                => Subjects = subjects;

            [MethodImpl(Inline), Op]
            public static bit check(char src, ReadOnlySpan<char> subjects)
            {
                var count = subjects.Length;
                if(count == 0)
                    return false;
                for(var i=0u; i<count; i++)
                {
                    if(skip(subjects,i) == src)
                        return true;
                }
                return false;
            }

            [MethodImpl(Inline)]
            public bit Check(char c)
                => check(c, Subjects);
        }
    }
}