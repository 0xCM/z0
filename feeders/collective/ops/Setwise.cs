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
        public static ISet<T> Unions<T>(this ISet<T> a, params ISet<T>[]  sets)
        {
            for(var i=0; i<sets.Length; i++)
            foreach(var item in sets[i])
                a.Add(item);
            return a;
        }

        public static ISet<T> Intersection<T>(this ISet<T> s1, ISet<T> s2)
        {
            var dst = new HashSet<T>(s1);
            dst.IntersectWith(s2);
            return dst;        
        }

        public static void Include<T>(this ISet<T> dst, IEnumerable<T> src )
            => Streams.iter(src, item => dst.Add(item));
        
        public static void Include<T>(this ISet<T> dst, params T[] src)
            => Streams.iter(src, item => dst.Add(item));


       /// <summary>
        /// Constructs a set from a sequence
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="items">The item sequence</param>
        public static ISet<T> ToSet<T>(this IEnumerable<T> items)
            => new HashSet<T>(items);

        /// <summary>
        /// Constructs a set from a sequence projection
        /// </summary>
        /// <typeparam name="T">The source element type</typeparam>
        /// <typeparam name="U">The targert element type</typeparam>
        /// <param name="items">The item sequence</param>
        public static ISet<U> ToSet<T, U>(this IEnumerable<T> items, Func<T, U> selector)
            => new HashSet<U>(items.Select(selector));

        /// <summary>
        /// Constructs a readonly set from a sequence
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        public static HashSet<T> ToReadOnlySet<T>(this IEnumerable<T> items)
            => items.ToHashSet();

        /// <summary>
        /// Determines whether a set is empty
        /// </summary>
        /// <typeparam name="T">The type of element that may be contained in the set</typeparam>
        /// <param name="set">The set under examination</param>
        [MethodImpl(Inline)]
        public static bool IsEmpty<T>(this ISet<T> set)
            => set.Count == 0;

        /// <summary>
        /// Determines whether a set is nonempty
        /// </summary>
        /// <typeparam name="T">The type of element that may be contained in the set</typeparam>
        /// <param name="set">The set under examination</param>
        [MethodImpl(Inline)]
        public static bool IsNonEmpty<T>(this ISet<T> set)
            => set.Count != 0;        

        /// <summary>
        /// Determines whether a collection contains any elements
        /// </summary>
        /// <typeparam name="T">The type of item contained by the collection</typeparam>
        /// <param name="src">The collection to examine</param>
        [MethodImpl(Inline)]
        public static bool IsEmpty<T>(this IReadOnlyCollection<T> src)
             => src.Count == 0;
    }
}