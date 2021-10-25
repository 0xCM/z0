//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IEvalCapture
    {
        IExpr Input {get;}

        IExpr Output {get;}
    }

    public interface IEvalCapture<S,T> : IEvalCapture
        where S : IExpr
        where T : IExpr
    {
        new S Input {get;}

        new T Output {get;}

        IExpr IEvalCapture.Input
            => Input;

        IExpr IEvalCapture.Output
            => Output;
    }
}