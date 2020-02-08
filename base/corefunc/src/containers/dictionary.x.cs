//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static zfunc;

    partial class xfunc
    {

        /// <summary>
        /// Addes the entries of the source dictionary to the destination dictionary
        /// </summary>
        /// <typeparam name="TKey">The common dictionary key type</typeparam>
        /// <typeparam name="TValue">The common dictionary value type</typeparam>
        /// <param name="dst">The target dictionary</param>
        /// <param name="src">The source dictionary</param>
        public static void AddRange<TKey, TValue>(this IDictionary<TKey, TValue> dst, IReadOnlyDictionary<TKey, TValue> src)
                => src.Iterate(s => dst.Add(s.Key, s.Value));

        /// <summary>
        /// Addes the key-value pairs to the extended dictionary
        /// </summary>
        /// <typeparam name="K">The dictionary key type</typeparam>
        /// <typeparam name="V">The dictionary value type</typeparam>
        /// <param name="dict">The extended dictionary</param>
        /// <param name="items">The items to add</param>
        public static void AddRange<K, V>(this IDictionary<K, V> dict, IEnumerable<KeyValuePair<K, V>> items)
            => items.Iterate( item => dict.Add(item));

        /// <summary>
        /// Determines whether the dictionary has any the keys that are specified in a set
        /// </summary>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="subject">The dictionary to evaluate</param>
        /// <param name="keys">The keys to check</param>
        public static bool HasAnyKey<K, V>(this IReadOnlyDictionary<K, V> subject, IEnumerable<K> keys)
            => keys.Intersect(subject.Keys).Any();

        /// <summary>
        /// Determines whether the dictionary has all of the keys that are specified in a set
        /// </summary>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="subject">The dictionary to evaluate</param>
        /// <param name="keys">The keys to check</param>
        public static bool HasAllKeys<K, V>(this IReadOnlyDictionary<K, V> subject, IEnumerable<K> keys)
            => keys.Count(k => subject.ContainsKey(k)) == keys.Count();

        static Option<Y> guard<X, Y>(X x, Func<X, bool> predicate, Func<X, Option<Y>> f)
            => predicate(x) ? f(x) : none<Y>();

        /// <summary>
        /// Retrieves the key-identified value if possible
        /// </summary>
        /// <typeparam name="K">The key</typeparam>
        /// <typeparam name="V">The type of value identified by the key</typeparam>
        /// <param name="subject">The collection to query</param>
        /// <param name="key">The key that identifies the value</param>
        public static Option<V> TryFind<K, V>(this Dictionary<K, V> subject, K key)
            => guard(key,
                k => k != null,
                k => subject.TryGetValue(k, out V value)
                    ? some(value)
                    : none<V>());

        /// <summary>
        /// Retrieves the key-identified value if possible
        /// </summary>
        /// <typeparam name="K">The key</typeparam>
        /// <typeparam name="V">The type of value identified by the key</typeparam>
        /// <param name="subject">The collection to query</param>
        /// <param name="key">The key that identifies the value</param>
        public static Option<V> TryFind<K, V>(this IReadOnlyDictionary<K, V> subject, K key)
                => key == null ? none<V>()
                : (subject.TryGetValue(key, out V value)
                ? some(value) : none<V>());
    }
}