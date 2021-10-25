//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct rules
    {
        [MethodImpl(Inline)]
        public static Test<C> test<C>(C condition)
            where C : IExpr
                => new Test<C>(condition);
    }
}