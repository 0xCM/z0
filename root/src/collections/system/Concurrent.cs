//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;

    
    using static Root;
    
    partial class SystemCollections
    {
        /// <summary>
        /// Creates a concurrent dictionary from an ordinary dictionary
        /// </summary>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="d">The source dictionary</param>
        [MethodImpl(Inline)]
        public static ConcurrentDictionary<K, V> ToConcurrentDictionary<K, V>(this IDictionary<K, V> d)
            => new ConcurrentDictionary<K, V>(d);

        /// <summary>
        /// Creates a concurrent dictionary from the input sequence
        /// </summary>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="values">The input sequence</param>
        /// <param name="keySelector"></param>
        [MethodImpl(Inline)]
        public static ConcurrentDictionary<K, V> ToConcurrentDictionary<K, V>(this IEnumerable<V> values, Func<V, K> keySelector)
            => new ConcurrentDictionary<K, V>(
                from value in values select new KeyValuePair<K, V>(keySelector(value), value));

        /// <summary>
        /// Creates a concurrent dictionary from the input sequence
        /// </summary>
        /// <typeparam name="S">The input sequence type</typeparam>
        /// <typeparam name="K">The dictionary key type</typeparam>
        /// <typeparam name="V">The type of the indexed valuie</typeparam>
        /// <param name="sources">The input sequence</param>
        /// <param name="keySelector">Function that selects the key</param>
        /// <param name="valueSelector">Function that selects the value</param>
        [MethodImpl(Inline)]
        public static ConcurrentDictionary<K, V> ToConcurrentDictionary<S, K, V>(this IEnumerable<S> sources, 
            Func<S, K> keySelector, Func<S, V> valueSelector)
                => new ConcurrentDictionary<K, V>
                        (from item in sources select new KeyValuePair<K, V>(keySelector(item), valueSelector(item)));

        /// <summary>
        /// Removes the key-identified value if possible
        /// </summary>
        /// <typeparam name="K">The key</typeparam>
        /// <typeparam name="V">The type of value identified by the key</typeparam>
        /// <param name="subject">The collection to query</param>
        /// <param name="key">The key that identifies the value</param>
        [MethodImpl(Inline)]
        public static Option<V> TryRemove<K, V>(this ConcurrentDictionary<K, V> subject, K key)
            => Option.guard(key,
                k => k != null,
                k => subject.TryRemove(k, out V value)
                    ? some(value)
                    : none<V>());

        /// <summary>
        /// A functional rendition of <see cref="ConcurrentBag{T}.TryTake(out T)"/> 
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="source">The collection to search</param>
        [MethodImpl(Inline)]
        public static Option<T> TryTake<T>(this ConcurrentBag<T> source)
            => (source.TryTake(out T element)) ? some(element) : none<T>();
    }
}