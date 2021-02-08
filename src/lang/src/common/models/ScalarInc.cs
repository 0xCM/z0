//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ScalarInc : IExpr<ScalarInc>
    {
        public long Step {get;}

        [MethodImpl(Inline)]
        public ScalarInc(long step)
        {
            Step = step;
        }
    }
}