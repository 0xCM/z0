//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct UnaryLogicOpExpr<T> :  IUnaryLogicOpExpr<T>
        where T : unmanaged
    {
        public UnaryBitLogicKind ApiClass {get;}

        public ILogicExpr<T> Arg{get;}

        [MethodImpl(Inline)]
        internal UnaryLogicOpExpr(UnaryBitLogicKind kind, ILogicExpr<T> arg)
        {
            this.Arg = arg;
            this.ApiClass = kind;
        }

        ILogicExpr IUnaryOpExpr<ILogicExpr>.Arg
            => Arg;

        public string Format()
            => ApiClass.Format(Arg);
    }
}