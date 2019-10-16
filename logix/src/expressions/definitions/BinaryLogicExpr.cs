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
    public sealed class BinaryLogicExpr : IBinaryLogicOp
    {
        [MethodImpl(Inline)]
        public BinaryLogicExpr(BinaryLogicKind op, ILogicExpr left, ILogicExpr right)
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
        public ILogicExpr Left {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public ILogicExpr Right {get;}

        public string Format()
            => $"{Left} {Operator} {Right}";
        
        public override string ToString()
            => Format();

    } 

}