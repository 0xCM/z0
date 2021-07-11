//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct Dec
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
}