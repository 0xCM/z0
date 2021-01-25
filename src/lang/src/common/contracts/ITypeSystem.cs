//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface ITypeSystem
    {

    }

    public interface ITypeSystem<T> : ITypeSystem
        where T : ITypeSystem
    {

    }

    public interface ITypeSystem<K,T> : ITypeSystem<T>
        where T : ITypeSystem
        where K : unmanaged, Enum, IEquatable<K>
    {
        Index<K> Kinds {get;}
    }
}