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
    public sealed class BinaryLogicExpr<T> : IBinaryLogicOp<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BinaryLogicExpr(BinaryLogicKind op, IExpr<T> left, IExpr<T> right)
        {
            this.Operator = op;
            this.Left = left;
            this.Right = right;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public BinaryLogicKind Operator {get;}

        /// <summary>
        /// Specifies the number of parameters accepted by the expression
        /// </summary>
        public ArityKind Arity => ArityKind.Binary;

        /// <summary>
        /// The left operand
        /// </summary>
        public IExpr<T> Left {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public IExpr<T> Right {get;}

    }


}