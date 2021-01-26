//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IApiClass : ITextual
    {
        ApiClass ClassId {get;}
        string ITextual.Format()
            => ClassId.ToString();
    }

    public interface IApiClass<K> : IApiClass
        where K : unmanaged
    {
        new K ClassId {get;}

        ApiClass IApiClass.ClassId
            => Root.@as<K,ApiClass>(ClassId);
    }

    public interface IApiClass<F,K> : IApiClass<K>, IEquatable<F>
        where K : unmanaged
        where F : unmanaged, IApiClass<F,K>
    {

    }
}