//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        [MethodImpl(Inline)]
        public static Constraint<S,R> constrain<S,R>(S subject, R rule)
            => new Constraint<S,R>(subject,rule);
    }
}