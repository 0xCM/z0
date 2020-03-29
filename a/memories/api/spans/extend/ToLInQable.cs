//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static Memories;

    partial class XMem
    {
        /// <summary>
        /// Constructs a hash set from span content
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The item type</typeparam>
        public static ISet<T> ToSet<T>(this Span<T> src)        
            where T : unmanaged
                => Spans.set(src.ReadOnly());

        /// <summary>
        /// Constructs a hash set from span content
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The item type</typeparam>
        public static ISet<T> ToSet<T>(this ReadOnlySpan<T> src)        
            where T : unmanaged
                => Spans.set(src);

        /// <summary>
        /// Constructs a hash set from span content
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The item type</typeparam>
        public static ISet<T> ToSet<T>(this ReadOnlySpan<T> a, ReadOnlySpan<T> b)        
            where T : unmanaged
                => Spans.set(a,b);

        /// <summary>
        /// Constructs a hash set from span content
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The item type</typeparam>
        public static ISet<T> ToSet<T>(this Span<T> src, ReadOnlySpan<T> b)        
            where T : unmanaged
                => src.ReadOnly().ToSet(b);


        /// <summary>
        /// Lifts the content of a span into a LINQ enumerable
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<T> ToEnumerable<T>(this ReadOnlySpan<T> src)
            => src.ToArray();
            
        /// <summary>
        /// Lifts the content of a span into a LINQ enumerable
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> ToEnumerable<T>(this Span<T> src)
            => src.ReadOnly().ToEnumerable();   
    }
}