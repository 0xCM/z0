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
    /// Represents a bitwise operator over three operands
    /// </summary>
    public sealed class TernaryBitExpr<T> : ITernaryBitExpr<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public TernaryBitExpr(BitOpKind op, IBitExpr<T> first, IBitExpr<T> second, IBitExpr<T> third)
        {
            this.Operator = op;
            this.First = first;
            this.Second = second;
            this.Third = third;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public BitOpKind Operator {get;}

        /// <summary>
        /// The first operand
        /// </summary>
        public IBitExpr<T> First {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        public IBitExpr<T> Second {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        public IBitExpr<T> Third {get;}

        /// <summary>
        /// The number of parameters accepted by the expression
        /// </summary>
        public ExprArity Arity => ExprArity.Ternary;     

    }

 
}