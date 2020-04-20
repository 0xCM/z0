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
}