//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Defines a typed unary arithmetic operator expression
    /// </summary>
    public sealed class UnaryAritheticOp<T> : IUnaryArithmeticOp<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public UnaryArithmeticOpKind OpKind {get;}

        /// <summary>
        /// The operand
        /// </summary>
        public IExpr<T> Arg {get;}

        public UnaryAritheticOp(UnaryArithmeticOpKind op, IExpr<T> operand)
        {
            this.OpKind = op;
            this.Arg = operand;
        }
        
        public string Format()
            => OpKind.Format(Arg);

        public override string ToString()
            => Format();
    }
}