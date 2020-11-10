//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IPackage<T> : IVersioned
        where T : struct, IPackage<T>
    {

    }

    [Free]
    public interface IScopedPackage<P,S> : IScoped<S>, IPackage<P>
        where P : struct, IPackage<P>
        where S : struct
    {

    }
}