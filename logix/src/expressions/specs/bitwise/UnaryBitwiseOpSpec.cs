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
    /// Joins an operator with left and right operands
    /// </summary>
    public sealed class UnaryBitwiseOpSpec<T> : IUnaryBitwiseOp<T>
        where T : unmanaged
    {
        public UnaryBitwiseOpSpec(UnaryBitwiseOpKind op, IExpr<T> operand)
        {
            this.OpKind = op;
            this.Arg = operand;
        }
        
        /// <summary>
        /// The operator
        /// </summary>
        public UnaryBitwiseOpKind OpKind {get;}

        /// <summary>
        /// The operand
        /// </summary>
        public IExpr<T> Arg {get;}

        public string Format()
            => OpKind.Format(Arg);

        public override string ToString()
            => Format();

    }


}