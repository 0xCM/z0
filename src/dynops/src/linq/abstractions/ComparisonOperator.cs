//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    
    /// <summary>
    /// Represents a comparison operator
    /// </summary>
    /// <typeparam name="O"></typeparam>
    public abstract class ComparisonOperator<O> : BinaryOperator<O>, IComparisonOperator
        where O : ComparisonOperator<O>
    {
        protected ComparisonOperator(string Name, string Symbol)
            : base(Name, Symbol)
        { }

        public new ComparisonOperatorApplication<O, T> Apply<T>(T Left, T Right)
            => new ComparisonOperatorApplication<O, T>(this, Left, Right);

        protected override IOperatorApplication DoApply(params object[] args)
            => Apply(args[0], args[1]);
    }
}
