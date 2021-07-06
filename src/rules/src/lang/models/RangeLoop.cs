//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    using Z0.Lang;

    partial struct Rules
    {
        public readonly struct RangeLoop : IRangeLoop
        {
            public IScope Scope {get;}

            public Range Range {get;}

            public RangeIterator Iterator {get;}

            public StatementBlock Body {get;}

            [MethodImpl(Inline)]
            public RangeLoop(IScope scope, Range range, RangeIterator iterator, StatementBlock body)
            {
                Scope = scope;
                Range = range;
                Iterator = iterator;
                Body = body;
            }
        }
    }
}