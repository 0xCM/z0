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
        /// Adds a collection of items to a bag
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="bag">The destination bag</param>
        /// <param name="items">The items to add</param>
        [MethodImpl(Inline)]
        public static void AddRange<T>(this ConcurrentBag<T> bag, IEnumerable<T> items)
            => items.Iter(item => bag.Add(item));

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
            
        /// <summary>
        /// Constructs an integrally-indexed stream from a source stream
        /// </summary>
        /// <param name="index">The 0-based element index</param>
        /// <param name="value">The indexed value</param>
        /// <typeparam name="T">The value type</typeparam>
        public static IEnumerable<(int index, T value)> Index<T>(this IEnumerable<T> src)
        {
            var i = 0;
            var it = src.GetEnumerator();            
            while(it.MoveNext())
                yield return (i++, it.Current);
        }
            
        /// <summary>
        /// Returns the second term of the sequence if it exists; otherwise raises an exception
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The source stream</param>
        public static T Second<T>(this IEnumerable<T> src)
            => src.Skip(1).Take(1).Single();

        /// <summary>
        /// Returns the third term of the sequence if it exists; otherwise raises an exception
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The source stream</param>
        public static T Third<T>(this IEnumerable<T> src)
            => src.Skip(2).Take(1).Single();

        /// <summary>
        /// Returns the second term of the sequence if it exists; otherwise returns the default value
        /// </summary>
        /// <typeparam name="T">The sequence item type</typeparam>
        /// <param name="src">The source stream</param>
        public static T SecondOrDefault<T>(this IEnumerable<T> src)
            => src.Take(2).LastOrDefault();

        /// <summary>
        /// Forces enumerable evaluation
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static T[] Force<T>(this IEnumerable<T> src)
            => src.ToArray();
 
        public static (IEnumerable<T> left, IEnumerable<T> right) Fork<T>(this IEnumerable<T> src)
            => (src, src);
        
        public static IEnumerable<T> Transform<S,T>(this IEnumerable<S> src, params Func<S,T>[] transformers)
            => src.Select(item => transformers.Select(t => t(item))).SelectMany(x => x);        
    }
}