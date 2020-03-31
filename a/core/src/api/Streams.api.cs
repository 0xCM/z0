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

    using static Components;

    public static class Streams
    {    
        /// <summary>
        /// Constructs a nonempty stream
        /// </summary>
        /// <param name="head">The first element in the stream</param>
        /// <param name="tail">The remaining elements of the stream</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        public static IEnumerable<T> nonempty<T>(T head, params T[] tail)
        {
            yield return head;

            foreach (var t in tail)
                yield return t;
        }

        /// <summary>
        /// Constructs a stream, possily empty
        /// </summary>
        /// <param name="src">The stream elements</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        public static IEnumerable<T> from<T>(params T[] src)
            => src;

        /// <summary>
        /// Concatenates the source streams to create a unified stream
        /// </summary>
        /// <param name="head">The first part of the sequence</param>
        /// <param name="tail">The last part of the sequence</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        public static IEnumerable<T> from<T>(IEnumerable<T> head, IEnumerable<T> tail)
            => head.Concat(tail);

        /// <summary>
        /// Concatenates the source streams to create a unified stream
        /// </summary>
        /// <param name="s1">The leading segment</param>
        /// <param name="s2">The second segment</param>
        /// <param name="s3">The terminal segment</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        public static IEnumerable<T> from<T>(IEnumerable<T> s1, IEnumerable<T> s2, IEnumerable<T> s3)
            => s1.Concat(s2).Concat(s3);

        /// <summary>
        /// All of your streams belong to us
        /// </summary>
        /// <param name="src">The source streams</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        public static IEnumerable<T> join<T>(params IEnumerable<T>[] src)
            => src.SelectMany(x => x);

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
    }
}