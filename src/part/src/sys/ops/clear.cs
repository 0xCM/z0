//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct sys
    {
        /// <summary>
        /// Fills a span with the element type's default value
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Options), Op, Closures(Closure)]
        public static Span<T> clear<T>(Span<T> src)
            => proxy.clear(src);

        /// <summary>
        /// Fills an array with the element type's default value
        /// </summary>
        /// <param name="dst">The source array</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Options), Op, Closures(Closure)]
        public static T[] clear<T>(T[] dst)
            where T : struct
                => proxy.clear(dst);
    }
}