//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    partial class XTend
    {
        /// <summary>
        /// Adds items from a stream to a target set
        /// </summary>
        /// <param name="dst">The target set</param>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The item type</typeparam>
        public static void Include<T>(this ISet<T> dst, IEnumerable<T> src)
            => src.Iter(item => dst.Add(item));

        /// <summary>
        /// Adds items from a parameter array to a target set
        /// </summary>
        /// <param name="dst">The target set</param>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The item type</typeparam>
        public static void Include<T>(this ISet<T> dst, params T[] src)
            => src.Iter(item => dst.Add(item));
    }
}