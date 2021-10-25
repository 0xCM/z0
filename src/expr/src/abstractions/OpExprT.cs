//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using System.Runtime.CompilerServices;
    
    using static Root;
    
    public abstract class OpExpr<F,K> : Expr<F,K>
        where F : OpExpr<F,K>
        where K : unmanaged
    {
        public abstract Label OpName {get;}

        [MethodImpl(Inline)]
        public static implicit operator AnyExpr(OpExpr<F,K> src)    
            => new AnyExpr(src);
    }
}