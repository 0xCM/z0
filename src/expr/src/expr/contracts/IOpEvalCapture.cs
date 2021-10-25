//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Joins an operation with an input value and the output value obtained by evaluating
    /// the operation the specified input
    /// </summary>
    public interface IOpEvalCapture
    {
        IOp Actor {get;}

        dynamic Input {get;}

        dynamic Output {get;}
    }

    public interface IOpEvalCapture<S> : IOpEvalCapture
    {
        new S Input {get;}

        dynamic IOpEvalCapture.Input
            => Input;
    }

    public interface IOpEvalCapture<S,T> : IOpEvalCapture<S>
    {
        new T Output {get;}

        dynamic IOpEvalCapture.Output
            => Output;
    }

    public interface IOpEvalCapture<O,S,T> : IOpEvalCapture<S,T>
        where O : IOp
    {
        new O Actor {get;}

        IOp IOpEvalCapture.Actor
            => Actor;
    }
}