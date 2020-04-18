//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Linq;

    public sealed class OrOperator : BinaryOperator<OrOperator>, ILogicalOperator
    {
        public OrOperator()
            : base("or", "||")
        {

        }
    }
}