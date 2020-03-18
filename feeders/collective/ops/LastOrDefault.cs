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

    using static Collective;

    partial class CollectiveOps
    {

        /// <summary>
        /// Returns the last element if it exists; otherwise returns the supplied default
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="default">The replacement value if the sequence is empty</param>
        public static T LastOrDefault<T>(this IEnumerable<T> src, T @default = default)
            => src.Any() ? src.Last() : @default;

        /// <summary>
        /// Returns the last element if it exists; otherwise returns the value supplied
        /// by invoking the default function
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="default">The function invoked to produce a default value</param>
        public static T LastOrDefault<T>(this IEnumerable<T> src, Func<T> @default)
            => src.Any() ? src.Last() : @default();
 
    }
}