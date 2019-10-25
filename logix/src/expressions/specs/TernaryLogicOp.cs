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
    public sealed class TernaryLogicOp : ITernaryLogicOp
    {
        [MethodImpl(Inline)]
        public TernaryLogicOp(TernaryBitOpKind op, ILogicExpr first, ILogicExpr second, ILogicExpr third)
        {
            this.OpKind = op;
            this.FirstArg = first;
            this.SecondArg = second;
            this.ThirdArg = third;
        }
        
        /// <summary>
        /// The expression classifier
        /// </summary>
        public LogicExprKind ExprKind
            => LogicExprKind.TernaryOperator;

        /// <summary>
        /// The operator
        /// </summary>
        public TernaryBitOpKind OpKind {get;}

        /// <summary>
        /// The first operand
        /// </summary>
        public ILogicExpr FirstArg {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        public ILogicExpr SecondArg {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        public ILogicExpr ThirdArg {get;}

        public string Format()
            => OpKind.Format(FirstArg,SecondArg,ThirdArg);
        
        public override string ToString()
            => Format();


    }

 
}