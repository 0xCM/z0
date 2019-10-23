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
        public TernaryOpSpec(Ternary512OpKind op, ITypedExpr<T> first, ITypedExpr<T> second, ITypedExpr<T> third)
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
            => TypedExprKind.TernaryOperator;

        /// <summary>
        /// The operator
        /// </summary>
        public Ternary512OpKind OpKind {get;}


        /// <summary>
        /// The first operand
        /// </summary>
        public ITypedExpr<T> FirstArg {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        public ITypedExpr<T> SecondArg {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        public ITypedExpr<T> ThirdArg {get;}

        public string Format()
            => OpKind.Format(FirstArg,SecondArg,ThirdArg);
        
        public override string ToString()
            => Format();

    }

 
}