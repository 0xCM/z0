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
    /// Represents a logical operator over one operand
    /// </summary>
    public sealed class UnaryLogicExpr : IUnaryLogicOp
    {
        [MethodImpl(Inline)]
        public UnaryLogicExpr(UnaryLogicKind op, ILogicExpr operand)
        {
            this.Operator = op;
            this.Operand = operand;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public UnaryLogicKind Operator {get;}

        /// <summary>
        /// The number of parameters accepted by the expression
        /// </summary>
        public ArityKind Arity => ArityKind.Unary;

        /// <summary>
        /// The left operand
        /// </summary>
        public ILogicExpr Operand {get;}

        public string Format()
            => $"{Operator} {Operand}";

        public override string ToString()
            => Format();
    }

}