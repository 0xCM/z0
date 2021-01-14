//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Index
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool any<T>(Index<T> src)
            => src.Count != 0;

        /// <summary>
        /// Returns the first element if it exists; otherwise returns the supplied default
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="src">The items to search</param>
        /// <param name="default">The replacement value if the sequence is empty</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T firstOrDefault<T>(Index<T> src, T @default = default)
            => any(src) ? src.First : @default;
    }
}