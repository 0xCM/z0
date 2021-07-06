//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
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