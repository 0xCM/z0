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
            this.Operand = operand;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public UnaryLogicOpKind OpKind {get;}


        /// <summary>
        /// The left operand
        /// </summary>
        public ILogicExpr Operand {get;}

        public string Format()
            => OpKind.Format(Operand);

        public override string ToString()
            => Format();
    }

}