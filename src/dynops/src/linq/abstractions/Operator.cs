//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents an operator
    /// </summary>
    /// <typeparam name="OP">The operator type</typeparam>
    public abstract class Operator<OP> : IOperator where OP : Operator<OP>
    {
        protected Operator(string Name, string Symbol)
        {
            this.Name = Name;
            this.Symbol = Symbol;
        }

        /// <summary>
        /// The name of the operator
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The symbol used to denote the opeator
        /// </summary>
        public string Symbol { get; }


        public override string ToString()
            => Symbol;

        public abstract string FormatApply(params object[] args);

        protected abstract IOperatorApplication DoApply(params object[] args);

        IOperatorApplication IOperator.Apply(params object[] args)
            => DoApply(args);

    }

    
}
