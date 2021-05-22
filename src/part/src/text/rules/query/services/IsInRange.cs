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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static SymbolRange<T> range<T>(T min, T max)
            where T : unmanaged
                => new SymbolRange<T>(min,max);

        [MethodImpl(Inline), Op]
        public static IsInRange RangeRule(char min, char max)
            => new IsInRange(range(min,max));

        public readonly struct IsInRange : ISymbolicQuery<IsOneOf,char>
        {
            readonly SymbolRange<char> Range;

            [MethodImpl(Inline), Op]
            public IsInRange(SymbolRange<char> range)
                => Range = range;

            [MethodImpl(Inline)]
            public bit Check(char c)
                => T.contains(Range,c);
        }
    }
}