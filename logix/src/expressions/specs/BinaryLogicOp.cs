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
        /// The expression classifier
        /// </summary>
        public LogicExprKind ExprKind
            => LogicExprKind.BinaryOperator;

        /// <summary>
        /// The operator classifier
        /// </summary>
        public BinaryLogicOpKind OpKind {get;}

        /// <summary>
        /// The left operand
        /// </summary>
        public ILogicExpr LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public ILogicExpr RightArg {get;}

        public string Format()
            => OpKind.Format(LeftArg,RightArg);
        
        public override string ToString()
            => Format();

    } 

}