//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Dec : IExpr<Dec>
    {
        public IScope Scope {get;}

        public long Step {get;}

        [MethodImpl(Inline)]
        public Dec(IScope scope, long step)
        {
            Scope = scope;
            Step = step;
        }
    }
}