// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;
    
    partial class RootCollections
    {
        /// <summary>
        /// Constructs a hash set from span content
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The item type</typeparam>
        public static ISet<T> ToSet<T>(this Span<T> src)        
            where T : unmanaged
                => SpanOps.set(src.ReadOnly());

        /// <summary>
        /// Constructs a hash set from span content
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The item type</typeparam>
        public static ISet<T> ToSet<T>(this ReadOnlySpan<T> src)        
            where T : unmanaged
                => SpanOps.set(src);

        /// <summary>
        /// Constructs a hash set from span content
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The item type</typeparam>
        public static ISet<T> ToSet<T>(this ReadOnlySpan<T> a, ReadOnlySpan<T> b)        
            where T : unmanaged
                => SpanOps.set(a,b);

        /// <summary>
        /// Constructs a hash set from span content
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The item type</typeparam>
        public static ISet<T> ToSet<T>(this Span<T> src, ReadOnlySpan<T> b)        
            where T : unmanaged
                => src.ReadOnly().ToSet(b);

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
    }
}