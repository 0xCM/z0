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
    /// Defines a unary bitwise operator expression
    /// </summary>
    public sealed class UnaryBitwiseOpSpec<T> : IUnaryBitwiseOp<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public UnaryBitwiseOpKind OpKind {get;}

        /// <summary>
        /// The operand
        /// </summary>
        public IExpr<T> Arg {get;}

        public UnaryBitwiseOpSpec(UnaryBitwiseOpKind op, IExpr<T> operand)
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