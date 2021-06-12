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
        public readonly struct IsInRange : ISymbolQuery<IsOneOf,char>
        {
            readonly SymbolRange<char> Range;

            [MethodImpl(Inline), Op]
            public IsInRange(SymbolRange<char> range)
                => Range = range;

            [MethodImpl(Inline)]
            public bit Test(char c)
                => SymbolicQuery.contains(Range,c);
        }
    }
}