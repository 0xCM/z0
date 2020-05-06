//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    public interface IHashTable<K,V> : IReadOnlyDictionary<K,V>
    {
        new K[] Keys {get;}

        new V[] Values {get;}

        ISet<V> DistinctValues {get;}

        bool ContainsValue(V value);

        K[] this[V value]  {get;}

        bool TryGetKeys(V value, out K[] keys);

        K[] ValueKeys(V value);
    }
}