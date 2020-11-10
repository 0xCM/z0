//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPackage<T> : IVersioned
        where T : struct, IPackage<T>
    {

    }

    public interface IScopedPackage<P,S> : IScoped<S>, IPackage<P>
        where P : struct, IPackage<P>
        where S : struct
    {

    }
}