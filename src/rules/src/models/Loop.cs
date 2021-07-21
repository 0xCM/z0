//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Rules
    {
        public readonly struct Loop : IScopedLoop
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
}