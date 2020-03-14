//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IDynamicOpFactory<D,T> : IAppService
        where D : Delegate
    {

        D Manufacture(MethodInfo method, object instance);

        D Manufacture(MethodInfo method)
            => Manufacture(method,null);
    }

    public interface IDynamicEmitterOpFactory<T> : IDynamicOpFactory<Func<T>,T>
    {

    }

    public interface IDynamicUnaryOpFactory<T> : IDynamicOpFactory<Func<T,T>,T>
    {

    }

    public interface IDynamicBinaryOpFactory<T> : IDynamicOpFactory<Func<T,T,T>,T>
    {

    }

    public interface IDynamicTernaryOpFactory<T> : IDynamicOpFactory<Func<T,T,T,T>,T>
    {

    }
}