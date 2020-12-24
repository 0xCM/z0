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
    using static z;

    partial class XSpan
    {
        /// <summary>
        /// Creates a dictionary from a span using the element indices as keys
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [Op, Closures(Closure)]
        public static IDictionary<int,T> ToDictionary<T>(this ReadOnlySpan<T> src)
        {
            var count = src.Length;
            var dst = dict<int,T>(count);
            for(var i = 0u; i<count; i++)
                dst[(int)i] = skip(src,i);
            return dst;
        }

        /// <summary>
        /// Creates a dictionary from a span using the element indices as keys
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [Op, Closures(Closure)]
        public static IDictionary<int,T> ToDictionary<T>(this Span<T> src)
            => src.ReadOnly().ToDictionary();
    }
}