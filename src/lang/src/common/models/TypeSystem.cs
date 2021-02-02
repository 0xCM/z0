//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    public readonly struct TypeSystem<K> : ITypeSystem<K,TypeSystem<K>>
        where K : unmanaged, Enum, IEquatable<K>
    {
        public Index<K> Kinds {get;}
    }

    public readonly struct TypeSystem : ITypeSystem<TypeSystem>
    {

    }
}