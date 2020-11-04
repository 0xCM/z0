//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a typed ternary bitwise operator expression
    /// </summary>
    public sealed class TernaryBitwiseOpExpr<T> : ITernaryBitwiseOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public TernaryBitLogicKind ApiClass {get;}

        /// <summary>
        /// The first operand
        /// </summary>
        public IExpr<T> FirstArg {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        public IExpr<T> SecondArg {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        public IExpr<T> ThirdArg {get;}

        [MethodImpl(Inline)]
        public TernaryBitwiseOpExpr(TernaryBitLogicKind op, IExpr<T> first, IExpr<T> second, IExpr<T> third)
        {
            ApiClass = op;
            FirstArg = first;
            SecondArg = second;
            ThirdArg = third;
        }

        public string Format()
            => ApiClass.Format(FirstArg,SecondArg,ThirdArg);

        public override string ToString()
            => Format();
    }
}