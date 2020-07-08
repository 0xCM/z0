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

    using static Konst;

    partial struct As
    {

        // /// <summary>
        // /// Computs min(x.Length,y.Length)
        // /// </summary>
        // /// <param name="x">The first span</param>
        // /// <param name="y">The second span</param>
        // /// <typeparam name="S">The first span cell type</typeparam>
        // /// <typeparam name="T">The second span cell type</typeparam>
        // [MethodImpl(Inline)]
        // public static int length<S,T>(ReadOnlySpan<S> x, ReadOnlySpan<T> y)
        //     => core.min(x.Length, y.Length);

        /// <summary>
        /// Computs min(x.Length,y.Length)
        /// </summary>
        /// <param name="x">The first span</param>
        /// <param name="y">The second span</param>
        /// <typeparam name="S">The first span cell type</typeparam>
        /// <typeparam name="T">The second span cell type</typeparam>
        [MethodImpl(Inline)]
        public static int length<S,T>(ReadOnlySpan<S> x, Span<T> y)
            => core.min(x.Length, y.Length);

        /// <summary>
        /// Computs min(x.Length,y.Length)
        /// </summary>
        /// <param name="x">The first span</param>
        /// <param name="y">The second span</param>
        /// <typeparam name="S">The first span cell type</typeparam>
        /// <typeparam name="T">The second span cell type</typeparam>
        [MethodImpl(Inline)]
        public static int length<S,T>(Span<S> x, ReadOnlySpan<T> y)
            => core.min(x.Length, y.Length);

        /// <summary>
        /// Computs min(x.Length,y.Length)
        /// </summary>
        /// <param name="x">The first span</param>
        /// <param name="y">The second span</param>
        /// <typeparam name="S">The first span cell type</typeparam>
        /// <typeparam name="T">The second span cell type</typeparam>
        [MethodImpl(Inline)]
        public static int length<S,T>(Span<S> x, Span<T> y)
            => core.min(x.Length, y.Length);

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

            for(var i=0u; i<count; i++)
                f(skip(input,i));
        }

        // /// <summary>
        // /// Inovkes an action for each pair of elements in source spans of equal length
        // /// </summary>
        // /// <param name="src">The source span</param>
        // /// <param name="f">The receiver</param>
        // /// <typeparam name="T">The element type</typeparam>
        // [MethodImpl(Inline), Op, Closures(Closure)]
        // public static void iter<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Action<T,T> f)
        // {
        //     var count = a.Length;
        //     ref readonly var x = ref first(a);
        //     ref readonly var y = ref first(b);
            
        //     for(var i=0u; i<count; i++)
        //         f(skip(x,i),skip(y,i));
        // }

        // /// <summary>
        // /// Inovkes an action for each pair of elements in source spans of equal length
        // /// </summary>
        // /// <param name="src">The source span</param>
        // /// <param name="f">The receiver</param>
        // /// <typeparam name="T">The element type</typeparam>
        // [MethodImpl(Inline), Op, Closures(Closure)]
        // public static void iter<T>(Span<T> a, Span<T> b, Action<T,T> f)
        // {
        //     var count = a.Length;
        //     ref var x = ref first(a);
        //     ref var y = ref first(b);
            
        //     for(var i=0u; i<count; i++)
        //         f(skip(x,i), skip(y,i));
        // }

        /// <summary>
        /// Iterates over the supplied items, invoking a receiver for each
        /// </summary>
        /// <param name="src">The source items</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The item type</typeparam>
        public static void iter<T>(IEnumerable<T> items, Action<T> action, bool pll)
        {
            if (pll)
                items.AsParallel().ForAll(item => action(item));
            else
                foreach (var item in items)
                    action(item);
        }


        /// <summary>
        /// Iterates a pair of readonly spans in tandem, invoking a caller-supplied action for each cell pair
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="f">The action to invoke</param>
        /// <typeparam name="S">The cell type of the first operand</typeparam>
        /// <typeparam name="T">The cell type of the second operand</typeparam>
        [MethodImpl(Inline)]
        public static void iter<S,T>(ReadOnlySpan<S> left, ReadOnlySpan<T> right, Action<S,T> f)
        {
            var count = length(left,right);
            ref readonly var x = ref first(left);
            ref readonly var y = ref first(right);
            
            for(var i=0u; i<count; i++)
                f(skip(x,i), skip(y,i));
        }

        /// <summary>
        /// Iterates a pair of spans in tandem, invoking a caller-supplied action for each cell pair
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="f">The action to invoke</param>
        /// <typeparam name="S">The cell type of the first operand</typeparam>
        /// <typeparam name="T">The cell type of the second operand</typeparam>
        [MethodImpl(Inline)]
        public static void iter<S,T>(Span<S> x, Span<T> y, Action<S,T> f)
        {
            var count = core.min(x.Length, y.Length);
            for(var i=0u; i<count; i++)            
                f(skip(x,i),skip(y,i));            
        }
    }
}