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

    using static Part;

    partial struct Lookups
    {
        [MethodImpl(Inline)]
        public static KeyedValues<K,V> keyed<K,V>(KeyedValue<K,V>[] src)
            => new KeyedValues<K,V>(src);

        public static KeyedValues<K,V> keyed<K,V>(Dictionary<K,V> src)
            => new KeyedValues<K,V>(src.Select(x => root.kv(x.Key, x.Value)).Array());

        public static KeyedValues<K,V> keyed<K,V>(K key, V[] values)
            => new KeyedValues<K,V>(values.Select(value => root.kv(key, value)));

        public static KeyedValues<K,V> keyed<K,V>(Paired<K,V>[] src)
            => new KeyedValues<K,V>(src.Select(x => new KeyedValue<K,V>(x.Left, x.Right)));
    }
}