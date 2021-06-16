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

    using static Root;

    partial class XTend
    {
        [MethodImpl(Inline)]
        static IEnumerable<T> seq<T>(params T[] src)
            => src;

        /// <summary>
        /// Constructs a sequence of singleton sequences from a sequence of elements
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The item type</typeparam>
        public static IEnumerable<IEnumerable<T>> Singletons<T>(this IEnumerable<T> src)
            => from item in src select seq(item);

        /// <summary>
        /// Reduces a stream of element streams to an element stream
        /// </summary>
        /// <param name="src">The element streams</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<T> Collapse<T>(this IEnumerable<IEnumerable<T>> src)
            => src.SelectMany(y => y);
    }
}