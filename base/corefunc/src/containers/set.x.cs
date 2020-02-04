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
        /// Constructs a set from a sequence
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="items">The item sequence</param>
        [MethodImpl(Inline)]
        public static ISet<T> ToSet<T>(this IEnumerable<T> items)
            => new HashSet<T>(items);

        /// <summary>
        /// Constructs a set from a sequence projection
        /// </summary>
        /// <typeparam name="T">The source element type</typeparam>
        /// <typeparam name="U">The targert element type</typeparam>
        /// <param name="items">The item sequence</param>
        [MethodImpl(Inline)]
        public static ISet<U> ToSet<T, U>(this IEnumerable<T> items, Func<T, U> selector)
            => new HashSet<U>(items.Select(selector));

        /// <summary>
        /// Constructs a readonly set from a sequence
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        [MethodImpl(Inline)]
        public static HashSet<T> ToReadOnlySet<T>(this IEnumerable<T> items)
            => items.ToHashSet();

        /// <summary>
        /// Adds a stream of items to a set
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="set">The set to which items will be added</param>
        /// <param name="items">The items to add</param>
        [MethodImpl(Inline)]
        public static ISet<T> AddRange<T>(this ISet<T> set, IEnumerable<T> items)
        {
            items.Iterate(item => set.Add(item));
            return set;
        }

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
        
        public static Span<T> ToSpan<T>(this ISet<T> src)
        {
            var dst = span<T>(src.Count);
            var i = 0;
            foreach(var item in src)
                dst[i++] = item;
            return dst;
        }

        /// <summary>
        /// Constructs a hash set from span content
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The item type</typeparam>
        public static ISet<T> ToSet<T>(this Span<T> src)        
            where T : unmanaged
                => set(src.ReadOnly());

        /// <summary>
        /// Constructs a hash set from span content
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The item type</typeparam>
        public static ISet<T> ToSet<T>(this ReadOnlySpan<T> src)        
            where T : unmanaged
                => set(src);

        /// <summary>
        /// Constructs a hash set from span content
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The item type</typeparam>
        public static ISet<T> ToSet<T>(this ReadOnlySpan<T> a, ReadOnlySpan<T> b)        
            where T : unmanaged
                => set(a,b);

        /// <summary>
        /// Constructs a hash set from span content
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The item type</typeparam>
        public static ISet<T> ToSet<T>(this Span<T> src, ReadOnlySpan<T> b)        
            where T : unmanaged
                => src.ReadOnly().ToSet(b);

        [MethodImpl(Inline)]   
        public static ISet<T> Intersection<T>(this ISet<T> s1, ISet<T> s2)
        {
            var dst = new HashSet<T>(s1);
            dst.IntersectWith(s2);
            return dst;        
        }

        public static ISet<T> Unions<T>(this ISet<T> a, params ISet<T>[]  sets)
        {
            for(var i=0; i<sets.Length; i++)
            foreach(var item in sets[i])
                a.Add(item);
            return a;
        }

    }
}