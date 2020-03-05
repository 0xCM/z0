// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class SystemCollections
    {
        /// <summary>
        /// Removes a specified number of items from a queue
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="queue">The queue from which items will be removed</param>
        /// <param name="count">The (maximum) number of items to remove</param>
        public static IEnumerable<T> Dequeue<T>(this Queue<T> queue, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (queue.Count != 0)
                    yield return queue.Dequeue();
            }
        }

        /// <summary>
        /// Pops all items off the queue
        /// </summary>
        /// <typeparam name="T">The type of value contained int he queue</typeparam>
        /// <param name="q">The queue to manipulate</param>
        public static IEnumerable<T> Dequeue<T>(this ConcurrentQueue<T> q)
        {
            var item = default(T);
            var go = true;
            while (go)
            {
                if (q.TryDequeue(out item))
                    yield return item;
                else
                    go = false;
            }
        }

        /// <summary>
        /// Pops a sequence of items off a queue
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="q">The queue to manipulate</param>
        /// <param name="max">The maximum number of items to remove</param>
        public static IEnumerable<T> Dequeue<T>(this ConcurrentQueue<T> q, int max)
            => q.Dequeue().Take(max);


        /// <summary>
        /// Removes an element from the queue if one exists
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="q">the queue</param>
        public static Option<T> TryDequeue<T>(this ConcurrentQueue<T> q)
            => q.TryDequeue(out T next) ? some(next) : none<T>();

    }
}