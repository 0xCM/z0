//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    /// <summary>
    /// Captures a binary bitwise operator along with with its operands
    /// </summary>
    public sealed class BinaryBitwiseOpExpr<T> : IBinaryBitwiseOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public BinaryBitLogicKind OpKind {get;}

        /// <summary>
        /// The left operand
        /// </summary>
        public IExpr<T> LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public IExpr<T> RightArg {get;}

        [MethodImpl(Inline)]
        public BinaryBitwiseOpExpr(BinaryBitLogicKind op, IExpr<T> left, IExpr<T> right)
        {
            this.OpKind = op;
            this.LeftArg = left;
            this.RightArg = right;
        }

        /// <summary>
        /// Renders the expression in canonical form
        /// </summary>
        public string Format()
            => OpKind.Format(LeftArg,RightArg);
        
        public override string ToString()
            => Format();
    }
}