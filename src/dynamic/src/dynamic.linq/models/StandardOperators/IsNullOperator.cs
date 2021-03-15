//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Linq;

    public sealed class IsNullOperator : UnaryOperator<IsNullOperator>, INullityOperator<IsNullOperator>
    {
        internal IsNullOperator()
            : base("is_null", "is_null")
        { }
    }
}