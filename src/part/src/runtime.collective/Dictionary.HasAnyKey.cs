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

    partial class XTend
    {
        /// <summary>
        /// Determines whether the dictionary has any the keys that are specified in a set
        /// </summary>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="subject">The dictionary to evaluate</param>
        /// <param name="keys">The keys to check</param>
        public static bool HasAnyKey<K,V>(this IReadOnlyDictionary<K,V> subject, IEnumerable<K> keys)
            => keys.Intersect(subject.Keys).Any();

        /// <summary>
        /// Determines whether the dictionary has all of the keys that are specified in a set
        /// </summary>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="subject">The dictionary to evaluate</param>
        /// <param name="keys">The keys to check</param>
        public static bool HasAllKeys<K,V>(this IReadOnlyDictionary<K, V> subject, IEnumerable<K> keys)
            => keys.Count(k => subject.ContainsKey(k)) == keys.Count();
    }
}