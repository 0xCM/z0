//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    public sealed class NotNullOperator : UnaryOperator<NotNullOperator>, INullityOperator<NotNullOperator>
    {
        internal NotNullOperator()
            : base("not_null", "not_null")
        { }
    }
}