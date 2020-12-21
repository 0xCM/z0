//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a typed comparison predicate
    /// </summary>
    public sealed class ComparisonPredExpr<T> : IComparisonPredExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public BinaryComparisonApiClass ComparisonKind {get;}

        /// <summary>
        /// The left operand
        /// </summary>
        public IExpr<T> LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public IExpr<T> RightArg {get;}

        /// <summary>
        /// The variables upon which the operands depend
        /// </summary>
        public IVarExpr<T>[] Vars {get;}

        [MethodImpl(Inline)]
        public ComparisonPredExpr(BinaryComparisonApiClass op, IExpr<T> left, IExpr<T> right, params IVarExpr<T>[] vars)
        {
            ComparisonKind = op;
            LeftArg = left;
            RightArg = right;
            Vars = vars;
        }

        public void SetVars(params IExpr<T>[] values)
        {
            var count = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<count; i++)
                Vars[i].Set(values[i]);
        }

        public void SetVars(params T[] values)
        {
            var count = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<count; i++)
                Vars[i].Set(values[i]);
        }

        [MethodImpl(Inline)]
        public void SetVar(int index, T value)
            => Vars[index].Set(value);

        public string Format()
            => ComparisonKind.Format(LeftArg,RightArg);

        public override string ToString()
            => Format();
    }
}