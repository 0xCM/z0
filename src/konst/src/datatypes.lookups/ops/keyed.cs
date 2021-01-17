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
    using static memory;

    partial struct Lookups
    {
        [Op]
        public static KeyedValues<uint,TextBlock> keyed(in StringIndex src)
            => keyed(src,sys.alloc<KeyedValue<uint,TextBlock>>(src.Count));

        [MethodImpl(Inline), Op]
        public static KeyedValues<uint,TextBlock> keyed(in StringIndex src, KeyedValue<uint,TextBlock>[] buffer)
        {
            var keys = src.Keys.View;
            var values = src.Values.View;
            var count = keys.Length;
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = root.kvp(skip(keys,i), skip(values,i));
            return buffer;
        }

        [MethodImpl(Inline)]
        public static KeyedValues<K,V> keyed<K,V>(KeyedValue<K,V>[] src)
            => new KeyedValues<K,V>(src);

        public static KeyedValues<K,V> keyed<K,V>(Dictionary<K,V> src)
            => new KeyedValues<K,V>(src.Select(x => KeyedValue.define(x.Key, x.Value)).Array());

        public static KeyedValues<K,V> keyed<K,V>(K key, V[] values)
            => new KeyedValues<K,V>(values.Select(value => KeyedValue.define(key, value)));

        public static KeyedValues<K,V> keyed<K,V>(Paired<K,V>[] src)
            => new KeyedValues<K,V>(src.Select(x => new KeyedValue<K,V>(x.Left, x.Right)));
    }
}