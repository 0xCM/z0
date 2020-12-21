//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a unary bitwise operator expression
    /// </summary>
    public readonly struct UnaryBitwiseOpExpr<T> : IUnaryBitwiseOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public UnaryBitLogicKind ApiClass {get;}

        /// <summary>
        /// The operand
        /// </summary>
        public IExpr<T> Arg {get;}

        [MethodImpl(Inline)]
        public UnaryBitwiseOpExpr(UnaryBitLogicKind op, IExpr<T> operand)
        {
            ApiClass = op;
            Arg = operand;
        }

        public string Format()
            => ApiClass.Format(Arg);

        public override string ToString()
            => Format();
    }
}