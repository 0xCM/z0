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
    /// Represents a logical operator over one operand
    /// </summary>
    public sealed class UnaryLogicOp : IUnaryLogicOp
    {
        [MethodImpl(Inline)]
        public UnaryLogicOp(UnaryLogicOpKind op, ILogicExpr operand)
        {
            this.OpKind = op;
            this.Arg = operand;
        }
        
        /// <summary>
        /// The expression classifier
        /// </summary>
        public LogicExprKind ExprKind
            => LogicExprKind.UnaryOperator;

        /// <summary>
        /// The operator
        /// </summary>
        public UnaryLogicOpKind OpKind {get;}


        /// <summary>
        /// The left operand
        /// </summary>
        public ILogicExpr Arg {get;}

        public string Format()
            => OpKind.Format(Arg);

        public override string ToString()
            => Format();
    }

}