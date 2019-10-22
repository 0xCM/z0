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
    /// Represents a bitwise operator over three operands
    /// </summary>
    public sealed class TernaryOpSpec<T> : ITernaryOp<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public TernaryOpSpec(TernaryLogicOpKind op, IExpr<T> first, IExpr<T> second, IExpr<T> third)
        {
            this.OpKind = op;
            this.FirstArg = first;
            this.SecondArg = second;
            this.ThirdArg = third;
        }

        /// <summary>
        /// The expression classifier
        /// </summary>
        public TypedExprKind ExprKind 
            => TypedExprKind.Operator;

        /// <summary>
        /// The operator
        /// </summary>
        public TernaryLogicOpKind OpKind {get;}


        /// <summary>
        /// The first operand
        /// </summary>
        public IExpr<T> FirstArg {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        public IExpr<T> SecondArg {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        public IExpr<T> ThirdArg {get;}

        public string Format()
            => OpKind.Format(FirstArg,SecondArg,ThirdArg);
        
        public override string ToString()
            => Format();

    }

 
}