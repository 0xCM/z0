//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    public static class PipelineExtensions
    {
        /// <summary>
        /// Sends data from the source stream to a span receiver in batches
        /// </summary>
        /// <param name="items">The items to process</param>
        /// <param name="receiver">The processor</param>
        /// <param name="batchSize">The block size</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void SendBatches<T>(this IEnumerable<T> items, SpanReceiver<T> receiver, int batchSize, Action<int> processed)
        {
            Span<T> batch = new T[batchSize];
            var index = 0;
            foreach (var item in items)
            {
                batch[index++] = item;
                if (index == batchSize)
                {
                    receiver(batch);
                    processed(batchSize);
                    batch.Clear();
                    index = 0;
                }
            }

            if (index != 0)
            {
                receiver(batch);
                processed(index);
            }

            batch.Clear();
        }

        /// <summary>
        /// Sends data from the source stream to a span receiver in batches
        /// </summary>
        /// <param name="items">The items to process</param>
        /// <param name="processor">The processor</param>
        /// <param name="batchSize">The block size</param>
        /// <typeparam name="T"></typeparam>
        public static void SendBatches<T>(this IEnumerable<T> items, SpanReceiver<T> processor, int batchSize)
            => items.SendBatches(processor, batchSize, (count) => { });
    }
}
