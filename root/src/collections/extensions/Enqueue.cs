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
    }
}