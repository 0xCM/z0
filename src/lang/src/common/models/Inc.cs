//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Inc : IExpr<Inc>
    {
        public IScope Scope {get;}

        public long Step {get;}

        [MethodImpl(Inline)]
        public Inc(IScope scope, long step)
        {
            Scope = scope;
            Step = step;
        }
    }
}