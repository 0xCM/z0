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
    public sealed class TernaryLogicExpr<T> : ITernaryLogicOp<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public TernaryLogicExpr(TernaryLogicKind op, ILogicExpr<T> first, ILogicExpr<T> second, ILogicExpr<T> third)
        {
            this.Operator = op;
            this.First = first;
            this.Second = second;
            this.Third = third;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public TernaryLogicKind Operator {get;}

        /// <summary>
        /// The first operand
        /// </summary>
        public ILogicExpr<T> First {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        public ILogicExpr<T> Second {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        public ILogicExpr<T> Third {get;}

        /// <summary>
        /// The number of parameters accepted by the expression
        /// </summary>
        public ArityKind Arity => ArityKind.Ternary;     

    }

 
}