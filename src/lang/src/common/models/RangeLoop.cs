//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RangeLoop : IRangeLoop
    {
        public IScope Scope {get;}

        public Range Range {get;}

        public RangeIterator Iterator {get;}

        public CodeBlock Body {get;}

        [MethodImpl(Inline)]
        public RangeLoop(IScope scope, Range range, RangeIterator iterator, CodeBlock body)
        {
            Scope = scope;
            Range = range;
            Iterator = iterator;
            Body = body;
        }
    }
}