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
    public sealed class UnaryLogicExpr : IUnaryLogicExpr
    {
        [MethodImpl(Inline)]
        public UnaryLogicExpr(LogicOpKind op, ILogicExpr operand)
        {
            this.Operator = op;
            this.Subject = operand;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public LogicOpKind Operator {get;}

        /// <summary>
        /// The number of parameters accepted by the expression
        /// </summary>
        public ExprArity Arity => ExprArity.Unary;

        /// <summary>
        /// The left operand
        /// </summary>
        public ILogicExpr Subject {get;}

        public string Format()
            => $"{Operator} {Subject}";

        public override string ToString()
            => Format();
    }

}