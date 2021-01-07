//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Collections.Concurrent;


    partial class XTend
    {
        /// <summary>
        /// Enqueues a stream
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="queue">The destination queue</param>
        /// <param name="items">The items to enqueue</param>
        public static void Enqueue<T>(this Queue<T> queue, IEnumerable<T> items)
        {
            foreach (var item in items)
                queue.Enqueue(item);
        }

        /// <summary>
        /// Pushes a sequence of items into queue and returns the number of items enqueued
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="q">The queue to manipulate</param>
        /// <param name="items">The items to place on the qeeue</param>
        public static int Enqueue<T>(this ConcurrentQueue<T> q, IEnumerable<T> items)
        {
            int count = 0;
            foreach (var item in items)
            {
                q.Enqueue(item);
                count++;
            }
            return count;
        }
    }
}