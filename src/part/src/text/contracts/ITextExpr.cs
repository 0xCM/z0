//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ITextExpr : ITextual
    {
        TextBlock Text {get;}

        string ITextual.Format()
            => Text.Format();
    }

    public interface ITextExpr<F> : ITextExpr
        where F : struct, ITextExpr<F>
    {

    }
}