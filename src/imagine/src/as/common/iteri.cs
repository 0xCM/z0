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
        /// <summary>
        /// Aplies an action to the sequence of integers min,min+1,...,max - 1
        /// </summary>
        /// <param name="min">The inclusive lower bound of the sequence</param>
        /// <param name="max">The non-inclusive upper bound of the sequence
        /// over intergers over which iteration will occur</param>
        /// <param name="f">The action to be applied to each  value</param>
        [MethodImpl(Inline), Op]
        public static void iteri(int min, int max, Action<int> f)
        {
            for(var i = min; i< max; i++) 
                f(i);
        }

        /// <summary>
        /// Applies an action to the increasing sequence of integers 0,1,2,...,count - 1
        /// </summary>
        /// <param name="count">The number of times the action will be invoked
        /// <param name="f">The action to be applied to each value</param>
        [MethodImpl(Inline), Op]
        public static void iteri(int count, Action<int> f)
        {
            for(var i = 0; i< count; i++) 
                f(i);
        }

        /// <summary>
        /// Iterates over the supplied items, invoking an indexed receiver for each
        /// </summary>
        /// <param name="src">The source items</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The item type</typeparam>
        public static void iteri<T>(IEnumerable<T> items, Action<int,T> action)
        {
            var it = items.GetEnumerator();
            var index = 0;
            while(it.MoveNext())
                action(index++, it.Current);
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
                f(i,skip(input,(uint)i));
        }
    }
}