//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    public readonly struct KeyedValues
    {
        public static KeyedValues<K,V> from<K,V>(Dictionary<K,V> src)
            => new KeyedValues<K,V>(src.Select(x => KeyedValue.define(x.Key, x.Value)).Array());

        public static KeyedValues<K,V> from<K,V>(K key, V[] values)
            => new KeyedValues<K,V>(values.Select(value => KeyedValue.define(key, value)).Array());

        public static KeyedValues<K,V> from<K,V>(Paired<K,V>[] src)
            => new KeyedValues<K,V>(src.Select(x => new KeyedValue<K,V>(x.Left, x.Right)));

        [MethodImpl(Inline)]
        public static KeyedValues<K,V> from<K,V>(KeyedValue<K,V>[] src)
            => new KeyedValues<K,V>(src);
    }
}