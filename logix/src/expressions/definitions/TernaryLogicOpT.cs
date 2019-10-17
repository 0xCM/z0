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
    public sealed class TernaryLogicOp<T> : ITernaryLogicOp<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public TernaryLogicOp(TernaryLogicOpKind op, ILogicExpr<T> first, ILogicExpr<T> second, ILogicExpr<T> third)
        {
            this.OpKind = op;
            this.FirstArg = first;
            this.SecondArg = second;
            this.ThirdArg = third;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public TernaryLogicOpKind OpKind {get;}

        /// <summary>
        /// The first operand
        /// </summary>
        public ILogicExpr<T> FirstArg {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        public ILogicExpr<T> SecondArg {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        public ILogicExpr<T> ThirdArg {get;}

        /// <summary>
        /// The number of parameters accepted by the expression
        /// </summary>
        public OpArityKind Arity => OpArityKind.Ternary;     

    }

 
}