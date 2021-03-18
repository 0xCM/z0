//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiClass : ITextual
    {
        ApiClass ClassId {get;}

        string ITextual.Format()
            => ClassId.ToString().ToLower();
    }

    public interface IApiClass<K> : IApiClass
        where K : unmanaged
    {
        K Kind {get;}

        ApiClass IApiClass.ClassId
            => Root.@as<K,ApiClass>(Kind);
    }

    public interface IApiClass<F,K> : IApiClass<K>, IEquatable<F>
        where K : unmanaged
        where F : unmanaged, IApiClass<F,K>
    {

    }
}