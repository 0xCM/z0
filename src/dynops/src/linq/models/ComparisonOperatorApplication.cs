//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ComparisonOperatorApplication<OP, T> : OperatorApplication<OP>
        where OP : BinaryOperator<OP>
    {
        public ComparisonOperatorApplication(BinaryOperator<OP> Operator, T Left, T Right)
            : base(Operator, Left, Right)
        {
        }

        public T Left => (T)Operands[0];

        public T Right => (T)Operands[1];


        public override string ToString()
            => $"{Left} {Operator} {Right}";
    }
}
