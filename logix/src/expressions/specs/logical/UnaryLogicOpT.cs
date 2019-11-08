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

    public sealed class UnaryLogicOp<T> : UnaryLogicOp,  IUnaryLogicOp<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public UnaryLogicOp(UnaryLogicOpKind op, ILogicExpr<T> arg)
            : base(op,arg)
        {
            this.Arg = arg;
        }

        public new ILogicExpr<T> Arg{get;}

    }
}