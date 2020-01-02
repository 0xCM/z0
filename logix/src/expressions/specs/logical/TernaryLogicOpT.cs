//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Defines a typed ternary logic operator expression
    /// </summary>
    public sealed class TernaryLogicOp<T> : TernaryLogicOp, ITernaryLogicOp<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public new TernaryOpKind OpKind {get;}

        /// <summary>
        /// The first operand
        /// </summary>
        public new ILogicExpr<T> FirstArg {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        public new ILogicExpr<T> SecondArg {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        public new ILogicExpr<T> ThirdArg {get;}

        [MethodImpl(Inline)]
        public TernaryLogicOp(TernaryOpKind op, ILogicExpr<T> arg1, ILogicExpr<T> arg2, ILogicExpr<T> arg3)
            : base(op, arg1,arg2,arg3)
        {
            this.OpKind = op;
            this.FirstArg = arg1;
            this.SecondArg = arg2;
            this.ThirdArg = arg3;
        }
    }
}