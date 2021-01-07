//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IType
    {

    }

    public interface IType<T>
        where T : struct, IType<T>
    {

    }

    public interface IType<K,T>
        where T : struct, IType<T>
        where K : unmanaged, Enum, IEquatable<K>
    {
        K Kind {get;}
    }

    public readonly struct TypeSystem<K> : ITypeSystem<K,TypeSystem<K>>
        where K : unmanaged, Enum, IEquatable<K>
    {
        public Index<K> Kinds {get;}
    }

    public readonly struct TypeSystem : ITypeSystem<TypeSystem>
    {

    }

    public readonly partial struct TypeSystems
    {

    }
}