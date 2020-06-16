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

    partial class Control    
    {
        /// <summary>
        /// Iterates over the supplied items, invoking a receiver for each
        /// </summary>
        /// <param name="src">The source items</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The item type</typeparam>
        public static void iter<T>(IEnumerable<T> items, Action<T> action, bool pll = false)
        {
            if (pll)
                items.AsParallel().ForAll(item => action(item));
            else
                foreach (var item in items)
                    action(item);
        }

        [MethodImpl(Inline), Op]
        public static void iter<T>(ReadOnlySpan<T> src, Action<T> action)
        {
            for(var i=0; i<src.Length; i++)
                action(skip(src,i));
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
        public static void iter<S,T>(ReadOnlySpan<S> x, ReadOnlySpan<T> y, Action<S,T> f)
        {
            var count = min(x.Length, y.Length);
            for(var i=0; i<count; i++)            
                f(skip(x,i),skip(y,i));            
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
            var count = min(x.Length, y.Length);
            for(var i=0; i<count; i++)            
                f(skip(x,i),skip(y,i));            
        }
    }
}