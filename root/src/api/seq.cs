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
        /// Consructs an enumerable from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> items<T>(params T[] src)
            => src;

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
    }
}