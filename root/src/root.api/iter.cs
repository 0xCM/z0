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

        /// <summary>
        /// Inovkes an action for each pair of elements in source spans of equal length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void iter<T>(ReadOnlySpan<T> first, ReadOnlySpan<T> second, Action<T,T> f)
        {
            var count = Checks.length(first,second);
            ref readonly var x = ref head(first);
            ref readonly var y = ref head(second);
            
            for(var i=0; i<count; i++)
                f(skip(x,i),skip(y,i));
        }

        /// <summary>
        /// Inovkes an action for each pair of elements in source spans of equal length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void iter<T>(Span<T> first, Span<T> second, Action<T,T> f)
            => iter(first.ReadOnly(), second.ReadOnly(),f);

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
        /// Invokes a handler for each key-value pair in the source
        /// </summary>
        /// <param name="items">The source items</param>
        /// <param name="action">The hanlder</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        public static void iter<K,V>(IEnumerable<KeyValuePair<K,V>> items, Action<K,V> action)
        {
            foreach(var kvp in items)
                action(kvp.Key, kvp.Value);
        }

        /// <summary>
        /// Aplies an action to the sequence of integers min,min+1,...,max - 1
        /// </summary>
        /// <param name="min">The inclusive lower bound of the sequence</param>
        /// <param name="max">The non-inclusive upper bound of the sequence
        /// over intergers over which iteration will occur</param>
        /// <param name="f">The action to be applied to each  value</param>
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
        public static void iteri(int count, Action<int> f)
        {
            for(var i = 0; i< count; i++) 
                f(i);
        }
    }
}