//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public sealed class NotNullOperator : UnaryOperator<NotNullOperator>, INullityOperator
    {
        internal NotNullOperator()
            : base("not_null", "not_null")
        { }
    }
}