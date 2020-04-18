//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections.Generic;    

    public sealed class UnaryOperatorApplication<OP, T> : OperatorApplication<OP>
        where OP : UnaryOperator<OP>
    {
        public UnaryOperatorApplication(UnaryOperator<OP> Operator, T Operand)
            : base(Operator, Operand)
        {

        }

        public T Operand => (T)Operands[0];

        public override string ToString()
            => $"{Operator}({Operand})";
    }
}
