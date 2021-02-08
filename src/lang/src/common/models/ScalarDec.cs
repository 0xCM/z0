//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ScalarDec : IExpr<ScalarDec>
    {
        public long Step {get;}

        [MethodImpl(Inline)]
        public ScalarDec(long step)
        {
            Step = step;
        }
    }
}