//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Joins an operator with left and right operands
    /// </summary>
    public sealed class UnaryAritheticOp<T> : IUnaryArithmeticOp<T>
        where T : unmanaged
    {
        public UnaryAritheticOp(UnaryArithmeticOpKind op, IExpr<T> operand)
        {
            this.OpKind = op;
            this.Operand = operand;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public UnaryArithmeticOpKind OpKind {get;}


        /// <summary>
        /// The operand
        /// </summary>
        public IExpr<T> Operand {get;}


        public string Format()
            => OpKind.Format(Operand);

    }


}