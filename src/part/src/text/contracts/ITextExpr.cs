//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    public interface ITextExpr : ITextual
    {
        Type ExprType {get;}

        string Content {get;}

        string ITextual.Format()
            => Content;
    }

    public interface ITextExpr<F> : ITextExpr
        where F : struct, ITextExpr<F>
    {
        Type ITextExpr.ExprType
            => typeof(F);
    }
}