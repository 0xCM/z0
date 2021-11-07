//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IEvaluation
    {
        IExpr Input {get;}

        IExpr Output {get;}
    }

    public interface IEvaluation<S,T> : IEvaluation
        where S : IExpr
        where T : IExpr
    {
        new S Input {get;}

        new T Output {get;}

        IExpr IEvaluation.Input
            => Input;

        IExpr IEvaluation.Output
            => Output;
    }
}