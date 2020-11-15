//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct SymbolicTests
    {
        public readonly struct IsInRange : ISymbolicTest<IsOneOf,char>
        {
            readonly SymbolicRange<char> Range;

            [MethodImpl(Inline), Op]
            public IsInRange(SymbolicRange<char> range)
                => Range = range;

            [MethodImpl(Inline), Op]
            public static bit check(char src, SymbolicRange<char> range)
                => src >= range.Min && src <= range.Max;

            [MethodImpl(Inline)]
            public bit Check(char c)
                => check(c, Range);
        }
    }
}