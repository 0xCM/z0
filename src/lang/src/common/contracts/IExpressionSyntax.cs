//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IExpressionSyntax : ISyntaxElement
    {

    }

    public interface IExpressionSyntax<T> : IExpressionSyntax
    {
        T Subject {get;}

        string ITextual.Format()
            => string.Format(RenderPattern, Subject);
    }

    public interface IExpressionSyntax<H,T> : IExpressionSyntax<T>
        where H : struct, IExpressionSyntax<H,T>
    {

    }
}