//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    /// <summary>
    /// Defines a unary bitwise operator expression
    /// </summary>
    public readonly struct UnaryBitwiseOpExpr<T> : IUnaryBitwiseOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public UnaryLogicKind OpKind {get;}

        /// <summary>
        /// The operand
        /// </summary>
        public IExpr<T> Arg {get;}

        public UnaryBitwiseOpExpr(UnaryLogicKind op, IExpr<T> operand)
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