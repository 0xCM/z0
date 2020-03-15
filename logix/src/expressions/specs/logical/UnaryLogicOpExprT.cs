//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public sealed class UnaryLogicOpExpr<T> : UnaryLogicOpExpr,  IUnaryLogicOpExpr<T>
        where T : unmanaged
    {
        public new ILogicExpr<T> Arg{get;}

        [MethodImpl(Inline)]
        internal UnaryLogicOpExpr(UnaryBitLogicOpKind op, ILogicExpr<T> arg)
            : base(op,arg)
                => this.Arg = arg;
    }
}