//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Switch : IStatement
    {
        public IScope Scope {get;}

        public Index<SwitchCase> Cases {get;}

        public Index<StatementBlock> Blocks {get;}

        public Switch(IScope scope, Index<SwitchCase> cases, Index<StatementBlock> blocks)
        {
            Scope = scope;
            Cases = cases;
            Blocks = blocks;
        }
    }
}