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

    partial class Root
    {
        /// <summary>
        /// Consructs an enumerable from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> items<T>(params T[] src)
            => src;

        /// <summary>
        /// Creates a set from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]   
        public static ISet<T> set<T>(params T[] src)
            => src.ToHashSet();

        /// <summary>
        /// Creates a list with specified capacity
        /// </summary>
        /// <param name="capacity">The list capacity</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]   
        public static List<T> list<T>(int capacity)
            => new List<T>(capacity);

        /// <summary>
        /// Creates a list from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]   
        public static List<T> list<T>(params T[] src)
            => src.ToList();

        /// <summary>
        /// Constructs a span from a parameter array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> span<T>(params T[] src)
            => src;

        /// <summary>
        /// Creates a new dictionary with an optionally-specified capacity
        /// </summary>
        /// <param name="capacity">The capacity</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]   
        public static Dictionary<K,V> dict<K,V>(int capacity = 0)
            => new Dictionary<K,V>(capacity);

        /// <summary>
        /// Creates a new dictionary populated with an initial set of entries
        /// </summary>
        /// <param name="entries">The initial entries</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]   
        public static Dictionary<K,V> dict<K,V>(params (K key, V value)[] entries)
            => entries.ToDictionary();

        /// <summary>
        /// Creates a deferred value
        /// </summary>
        /// <param name="factory">A function that produces a value upon demeand</param>
        [MethodImpl(Inline)]
        public static Lazy<T> defer<T>(Func<T> factory)
            => new Lazy<T>(factory);
    }
}