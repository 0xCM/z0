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

    using static Collective;

    partial class CollectiveOps
    {

        /// <summary>
        /// Constructs a mutable dictionary from a sequence of key-value pairs
        /// </summary>
        /// <param name="key">The key</param>
        /// <param name="value">The indexed value</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        public static Dictionary<K,V> ToDictionary<K,V>(this IEnumerable<(K key, V value)> src)
            => new Dictionary<K,V>(src.Select(x => new KeyValuePair<K,V>(x.key,x.value)));
    }
}