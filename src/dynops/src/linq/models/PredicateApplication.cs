//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PredicateApplication<O,X> : IPredicateAplication
        where O : Operator<O>
    {

        public PredicateApplication(O Operator)
        {
            this.Operator = Operator;
        }
        public O Operator { get; }

        protected virtual IReadOnlyList<object> Operands
            => new object[] { };

        IOperator IOperatorApplication.Operator
            => Operator;

        IReadOnlyList<object> IOperatorApplication.Operands
            => Operands;
    }
}
