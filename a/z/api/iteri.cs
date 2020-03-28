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

    partial class root
    {
        /// <summary>
        /// Iterates over the supplied items, invoking an indexed receiver for each
        /// </summary>
        /// <param name="src">The source items</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The item type</typeparam>
        public static void iteri<T>(IEnumerable<T> items, Action<int,T> action)
            => Streams.iteri(items,action);

        /// <summary>
        /// Aplies an action to the sequence of integers min,min+1,...,max - 1
        /// </summary>
        /// <param name="min">The inclusive lower bound of the sequence</param>
        /// <param name="max">The non-inclusive upper bound of the sequence
        /// over intergers over which iteration will occur</param>
        /// <param name="f">The action to be applied to each  value</param>
        public static void iteri(int min, int max, Action<int> f)
            => Streams.iteri(min,max,f);

        /// <summary>
        /// Applies an action to the increasing sequence of integers 0,1,2,...,count - 1
        /// </summary>
        /// <param name="count">The number of times the action will be invoked
        /// <param name="f">The action to be applied to each value</param>
        public static void iteri(int count, Action<int> f)
            => Streams.iteri(count,f);
    }
}