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
    /// Represents a logical operator over two operands
    /// </summary>
    public sealed class BinaryLogicOp : IBinaryLogicOp
    {
        [MethodImpl(Inline)]
        public BinaryLogicOp(BinaryLogicOpKind op, ILogicExpr left, ILogicExpr right)
        {
            this.OpKind = op;
            this.LeftArg = left;
            this.RightArg = right;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public BinaryLogicOpKind OpKind {get;}

        /// <summary>
        /// Specifies the number of parameters accepted by the expression
        /// </summary>
        public OpArityKind Arity => OpArityKind.Binary;

        /// <summary>
        /// The left operand
        /// </summary>
        public ILogicExpr LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public ILogicExpr RightArg {get;}

        public string Format()
            => $"{LeftArg} {OpKind} {RightArg}";
        
        public override string ToString()
            => Format();

    } 

}