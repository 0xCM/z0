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
    /// Defines the application of an untyped ternary logic operator
    /// </summary>
    public class TernaryLogicOp : ITernaryLogicOp
    {
        [MethodImpl(Inline)]
        public TernaryLogicOp(TernaryOpKind op, ILogicExpr arg1, ILogicExpr arg2, ILogicExpr arg3)
        {
            this.OpKind = op;
            this.FirstArg = arg1;
            this.SecondArg = arg2;
            this.ThirdArg = arg3;
        }

        public ILogicExpr FirstArg {get;}

        public ILogicExpr SecondArg {get;}

        public ILogicExpr ThirdArg {get;}

        public TernaryOpKind OpKind {get;}

        public string Format()
            => OpKind.Format(FirstArg,SecondArg,ThirdArg);        
        
        public override string ToString()
            => Format();
    }

    /// <summary>
    /// Defines the application of a typed ternary logic operator
    /// </summary>
    public sealed class TernaryLogicOp<T> : TernaryLogicOp, ITernaryLogicOp<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public TernaryLogicOp(TernaryOpKind op, ILogicExpr<T> arg1, ILogicExpr<T> arg2, ILogicExpr<T> arg3)
            : base(op, arg1,arg2,arg3)
        {
            this.OpKind = op;
            this.FirstArg = arg1;
            this.SecondArg = arg2;
            this.ThirdArg = arg3;
        }

        public new TernaryOpKind OpKind {get;}

        public new ILogicExpr<T> FirstArg {get;}

        public new ILogicExpr<T> SecondArg {get;}

        public new ILogicExpr<T> ThirdArg {get;}


    }

}