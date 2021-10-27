//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IExpr<K> : IExpr
        where K : unmanaged
    {
        K Kind {get;}
    }


    public abstract class Expr<F,K> : IExpr<K>
        where F : Expr<F,K>
        where K : unmanaged
    {
        public abstract K Kind {get;}

        public abstract string Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AnyExpr(Expr<F,K> src)
            => new AnyExpr(src);
    }
}