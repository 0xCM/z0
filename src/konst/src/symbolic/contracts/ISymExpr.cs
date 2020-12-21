//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISymExpr : INullity, ITextual
    {

    }

    public interface ISymExpr<T> : ISymExpr
    {
        T Body {get;}
    }

    public interface ISymExpr<F,T> : ISymExpr<T>, INullary<F>, IEquatable<F>
        where F : struct, ISymExpr<F,T>
    {

    }
}