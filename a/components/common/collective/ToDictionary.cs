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

    using static Seed;

    partial class XTend
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

        /// <summary>
        /// Creates a read-only dictionary from the supplied enumerable and selector
        /// </summary>
        /// <param name="this">The extended type</param>
        /// <param name="keySelector"></param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        public static IReadOnlyDictionary<K, V> ToReadOnlyDictionary<K, V>(this IEnumerable<V> @this, 
            Func<V, K> keySelector) => @this.ToDictionary(keySelector);

        /// <summary>
        /// Creates a read-only dictionary from an existing mutable dictionary
        /// </summary>
        /// <typeparam name="K">The dictionary key type</typeparam>
        /// <typeparam name="V">The dictionary value type</typeparam>
        /// <param name="this">The extended type</param>
        public static IReadOnlyDictionary<K, V> ToReadOnlyDictionary<K, V>(this IDictionary<K, V> @this)
            => new Dictionary<K, V>(@this);

        /// <summary>
        /// Creates a read-only dictionary from a stream of tuples
        /// </summary>
        /// <typeparam name="K">The dictionary key type</typeparam>
        /// <typeparam name="V">The dictionary value type</typeparam>
        /// <param name="this">The extended type</param>
        public static IReadOnlyDictionary<K, V> ToReadOnlyDictionary<K, V>(this IEnumerable<(K key, V value)> @this)
            => @this.ToDictionary(x => x.key, x => x.value);
    }
}