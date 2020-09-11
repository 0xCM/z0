//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines a typed unary arithmetic operator expression
    /// </summary>
    public readonly struct UnaryAritheticOpExpr<T> : IUnaryArithmeticOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public UnaryArithmeticOpId OpKind {get;}

        /// <summary>
        /// The operand
        /// </summary>
        public IExpr<T> Arg {get;}

        public UnaryAritheticOpExpr(UnaryArithmeticOpId op, IExpr<T> operand)
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