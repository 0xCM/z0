//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ITextExpr : ITextual
    {
        TextBlock Text {get;}

        string String
            => Text.Format();
        string ITextual.Format()
            => String;
    }

    public interface ITextExpr<F> : ITextExpr
        where F : struct, ITextExpr<F>
    {

    }
}