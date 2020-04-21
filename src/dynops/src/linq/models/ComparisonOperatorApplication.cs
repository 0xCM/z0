﻿//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ComparisonOperatorApplication<F,T> : OperatorApplication<F>
        where F : BinaryOperator<F>
    {
        public ComparisonOperatorApplication(BinaryOperator<F> f, T x, T y)
            : base(f, x, y)
        {
        }

        public T Left => (T)Operands[0];

        public T Right => (T)Operands[1];

        public override string ToString()
            => $"{Left} {Operator} {Right}";
    }
}
