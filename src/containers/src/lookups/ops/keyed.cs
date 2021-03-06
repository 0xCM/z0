//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static core;

    partial struct Lookups
    {
        public static KeyedValues<K,V> keyed<K,V>(Dictionary<K,V> src)
            => new KeyedValues<K,V>(src.Select(x => kvp(x.Key, x.Value)).Array());

        public static KeyedValues<K,V> keyed<K,V>(K key, V[] values)
            => new KeyedValues<K,V>(values.Select(value => kvp(key, value)));
    }
}