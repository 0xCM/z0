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
        public readonly struct IsInRange : ISymbolicTest<IsOneOf,char>
        {
            readonly SymbolicRange<char> Range;

            [MethodImpl(Inline), Op]
            public IsInRange(SymbolicRange<char> range)
                => Range = range;

            [MethodImpl(Inline)]
            public bit Check(char c)
                => contains(Range,c);
        }
    }
}