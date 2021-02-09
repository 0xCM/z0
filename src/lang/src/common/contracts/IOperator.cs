//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;

    public interface IOperator
    {
        uint2 Arity {get;}
    }

    public interface IOperator<T> : IOperator
    {

    }

    public interface IUnaryOperator : IOperator
    {
        uint2 IOperator.Arity => 1;
    }

    public interface IUnaryOperator<T> : IUnaryOperator,IOperator<T>
    {

    }

    public interface IBinaryOperator : IOperator
    {
        uint2 IOperator.Arity => 2;
    }

    public interface IBinaryOperator<T> : IBinaryOperator, IOperator<T>
    {
        uint2 IOperator.Arity => 2;

    }

    public interface ITernaryOperator : IOperator
    {
        uint2 IOperator.Arity => 3;
    }

    public interface ITernaryOperator<T> :  ITernaryOperator, IOperator<T>
    {

    }
}