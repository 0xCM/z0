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
    /// Defines a typed comparison expression
    /// </summary>
    public readonly struct ComparisonExpr<T> : IComparisonExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public BinaryComparisonApiClass ComparisonKind {get;}

        /// <summary>
        /// The left expression
        /// </summary>
        public IExpr<T> LeftArg {get;}

        /// <summary>
        /// The right expression
        /// </summary>
        public IExpr<T> RightArg {get;}

        /// <summary>
        /// The variables upon which the operands depend
        /// </summary>
        public IVarExpr<T>[] Vars {get;}

        [MethodImpl(Inline)]
        public ComparisonExpr(BinaryComparisonApiClass kind, IExpr<T> lhs, IExpr<T> rhs, params IVarExpr<T>[] vars)
        {
            ComparisonKind = kind;
            LeftArg = lhs;
            RightArg = rhs;
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