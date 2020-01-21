//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public sealed class UnaryLogicOp<T> : UnaryLogicOp,  IUnaryLogicOp<T>
        where T : unmanaged
    {
        public new ILogicExpr<T> Arg{get;}

        [MethodImpl(Inline)]
        internal UnaryLogicOp(UnaryBitLogicKind op, ILogicExpr<T> arg)
            : base(op,arg)
                => this.Arg = arg;
    }
}