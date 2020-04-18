//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class UnaryOperator<OP> : Operator<OP>
        where OP : UnaryOperator<OP>
    {

        protected UnaryOperator(string Name, string Symbol)
            : base(Name, Symbol)
        { }


        public UnaryOperatorApplication<OP, T> Apply<T>(T Operand)
            => new UnaryOperatorApplication<OP, T>(this, Operand);


        protected override IOperatorApplication DoApply(params object[] args)
            => Apply(args.First());


        public override string FormatApply(params object[] args)
            => $"{Symbol}({args.FirstOrDefault()}";
    }
}
