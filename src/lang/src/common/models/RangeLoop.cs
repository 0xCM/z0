//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RangeLoop
    {
        public Range Range {get;}

        public RangeIterator Iterator {get;}

        public CodeBlock Body {get;}

        [MethodImpl(Inline)]
        public RangeLoop(Range range, RangeIterator iterator, CodeBlock body)
        {
            Range = range;
            Iterator = iterator;
            Body = body;
        }
    }
}