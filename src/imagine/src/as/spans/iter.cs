//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static AsInternal;

    partial struct As
    {
        /// <summary>
        /// Inovkes an action for each element in a source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void iter<T>(ReadOnlySpan<T> src, Action<T> f)
        {
            ref readonly var input = ref first(src);
            int count = src.Length;

            for(var i=0; i<count; i++)
                f(skip(input,i));
        }

        /// <summary>
        /// Inovkes an action for each element in a source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void iteri<T>(ReadOnlySpan<T> src, Action<int,T> f)
        {
            ref readonly var input = ref first(src);
            int count = src.Length;

            for(var i=0; i<count; i++)
                f(i,skip(input,i));
        }

        /// <summary>
        /// Inovkes an action for each pair of elements in source spans of equal length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void iter<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Action<T,T> f)
        {
            var count = a.Length;
            ref readonly var x = ref first(a);
            ref readonly var y = ref first(b);
            
            for(var i=0; i<count; i++)
                f(skip(x,i),skip(y,i));
        }

        /// <summary>
        /// Inovkes an action for each pair of elements in source spans of equal length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void iter<T>(Span<T> a, Span<T> b, Action<T,T> f)
            => iter(a.ReadOnly(), b.ReadOnly(),f);
    }
}