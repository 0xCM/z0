//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    /// <summary>
    /// Defines a typed binary arithmetic operator expression
    /// </summary>
    public sealed class BinaryArithmeticOpExpr<T> : IBinaryArithmeticOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public BinaryArithmeticKind OpKind {get;}

        /// <summary>
        /// The left operand
        /// </summary>
        public IExpr<T> LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public IExpr<T> RightArg {get;}

        public BinaryArithmeticOpExpr(BinaryArithmeticKind op, IExpr<T> lhs, IExpr<T> rhs)
        {
            this.OpKind = op;
            this.LeftArg= lhs;
            this.RightArg = rhs;
        }
        
        /// <summary>
        /// Renders the expression in canonical form
        /// </summary>
        public string Format()
            => OpKind.Format(LeftArg, RightArg);
        
        public override string ToString()
            => Format();
    }
}