//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IOperatorFactory<D,T>
        where D : Delegate
    {
        D Create(MethodInfo method, object instance);

        D Create(MethodInfo method)
            => Create(method,null);
    }

    public interface IEmitterOpFactory<T> : IOperatorFactory<Func<T>,T>
    {

    }

    public interface IUnaryOpFactory<T> : IOperatorFactory<Func<T,T>,T>
    {

    }

    public interface IBinaryOpFactory<T> : IOperatorFactory<Func<T,T,T>,T>
    {

    }

    public interface ITernaryOpFactory<T> : IOperatorFactory<Func<T,T,T,T>,T>
    {

    }
}