//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public readonly struct UnaryLogicOpExpr<T> :  IUnaryLogicOpExpr<T>
        where T : unmanaged
    {
        public UnaryBitLogic OpKind {get;}

        public ILogicExpr<T> Arg{get;}

        [MethodImpl(Inline)]
        internal UnaryLogicOpExpr(UnaryBitLogic kind, ILogicExpr<T> arg)
        {
            this.Arg = arg;
            this.OpKind = kind;
        }
        
        ILogicExpr IUnaryOpExpr<ILogicExpr>.Arg 
            => Arg;

        public string Format()
            => OpKind.Format(Arg);        
    }
}