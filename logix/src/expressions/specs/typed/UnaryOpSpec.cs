//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Joins an operator with left and right operands
    /// </summary>
    public sealed class UnaryOpSpec<T> : IUnaryOp<T>
        where T : unmanaged
    {
        public UnaryOpSpec(UnaryLogicOpKind op, IExpr<T> operand)
        {
            this.OpKind = op;
            this.Operand = operand;
        }
        
        /// <summary>
        /// The expression classifier
        /// </summary>
        public TypedExprKind ExprKind 
            => TypedExprKind.Operator;


        /// <summary>
        /// The operator
        /// </summary>
        public UnaryLogicOpKind OpKind {get;}


        /// <summary>
        /// The operand
        /// </summary>
        public IExpr<T> Operand {get;}

        public string Format()
            => OpKind.Format(Operand);

        public override string ToString()
            => Format();

    }


}