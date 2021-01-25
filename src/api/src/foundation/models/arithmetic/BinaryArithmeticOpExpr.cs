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
    /// Defines a typed binary arithmetic operator expression
    /// </summary>
    public readonly struct BinaryArithmeticOpExpr<T> : IBinaryArithmeticOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public ApiBinaryArithmeticClass ApiClass {get;}

        /// <summary>
        /// The left operand
        /// </summary>
        public IExpr<T> LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public IExpr<T> RightArg {get;}

        [MethodImpl(Inline)]
        public BinaryArithmeticOpExpr(ApiBinaryArithmeticClass op, IExpr<T> lhs, IExpr<T> rhs)
        {
            ApiClass = op;
            LeftArg= lhs;
            RightArg = rhs;
        }

        /// <summary>
        /// Renders the expression in canonical form
        /// </summary>
        public string Format()
            => ApiClass.Format(LeftArg, RightArg);

        public override string ToString()
            => Format();
    }
}