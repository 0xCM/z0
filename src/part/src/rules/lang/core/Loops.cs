//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface ILoop : IScope, IScoped
    {
        StatementBlock Body {get;}
    }

    public readonly struct RangeIterator
    {
        public long Step {get;}

        [MethodImpl(Inline)]
        public RangeIterator(long step)
        {
            Step = step;
        }
    }

    public interface IRangeLoop : ILoop
    {
        Range Range {get;}

        RangeIterator Iterator {get;}
    }

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

    public readonly struct Loop : ILoop
    {
        public IScope Scope {get;}

        public StatementBlock Body {get;}

        public Loop(IScope scope, StatementBlock block)
        {
            Scope = scope;
            Body = block;
        }
    }
}