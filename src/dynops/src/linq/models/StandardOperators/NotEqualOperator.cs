//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Linq;

    public sealed class NotEqualOperator : ComparisonOperator<NotEqualOperator>
    {
        internal NotEqualOperator()
            : base("neq", "==")
        { }
    }
}