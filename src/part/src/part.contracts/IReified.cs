//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IReified
    {
        Type HostType {get;}
    }

    [Free]
    public interface IReified<T> : IReified
        where T : IReified<T>
    {
        Type IReified.HostType
            => typeof(T);
    }
}