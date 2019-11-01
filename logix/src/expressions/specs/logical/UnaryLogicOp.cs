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
    /// Represents a logical operator over one operand
    /// </summary>
    public class UnaryLogicOp : IUnaryLogicOp
    {
        [MethodImpl(Inline)]
        public UnaryLogicOp(UnaryLogicOpKind op, ILogicExpr arg)
        {
            this.OpKind = op;
            this.Arg = arg;
        }

        public ILogicExpr Arg {get;}

        public UnaryLogicOpKind OpKind {get;}

        public string Format()
            => OpKind.Format(Arg);        
    }

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