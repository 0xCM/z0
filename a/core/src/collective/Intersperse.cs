//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    partial class XTend
    {
       /// <summary>
        /// Interleaves a specified value between each element of the source
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="x">The value to interleave</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<T> Intersperse<T>(this IEnumerable<T> src, T x)
        {
            var items = src.ToArray();
            var count = items.Length;
            var last = count - 1;
            for(var i=0; i<count; i++)
            {
                yield return items[i];
                if(i != last)
                    yield return x;
            }
        }
    }
}