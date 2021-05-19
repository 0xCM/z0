//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    public interface IOperator
    {
        byte Arity {get;}
    }

    public interface IOperator<T> : IOperator
    {

    }

    public interface IUnaryOperator : IOperator
    {
        byte IOperator.Arity => 1;
    }

    public interface IUnaryOperator<T> : IUnaryOperator,IOperator<T>
    {

    }

    public interface IBinaryOperator : IOperator
    {
        byte IOperator.Arity => 2;
    }

    public interface IBinaryOperator<T> : IBinaryOperator, IOperator<T>
    {
        byte IOperator.Arity => 2;

    }

    public interface ITernaryOperator : IOperator
    {
        byte IOperator.Arity => 3;
    }

    public interface ITernaryOperator<T> :  ITernaryOperator, IOperator<T>
    {

    }
}