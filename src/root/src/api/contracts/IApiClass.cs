//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiClass : ITextual
    {
        ApiClassKind ClassId {get;}

        string ITextual.Format()
            => ClassId.ToString().ToLower();
    }

    public interface IApiClass<K> : IApiClass
        where K : unmanaged
    {
        K Kind {get;}

        ApiClassKind IApiClass.ClassId
            => Root.@as<K,ApiClassKind>(Kind);
    }

    public interface IApiClass<F,K> : IApiClass<K>, IEquatable<F>
        where K : unmanaged
        where F : unmanaged, IApiClass<F,K>
    {

    }
}