//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IOperatorFactory<D,T> : IService
        where D : Delegate
    {
        D Manufacture(MethodInfo method, object instance);

        D Manufacture(MethodInfo method)
            => Manufacture(method,null);
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