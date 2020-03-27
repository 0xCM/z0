//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    using static Components;

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

        /// <summary>
        /// Creates a new string by weaving a specified character between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="c">The character to intersperse</param>
        public static string Intersperse(this string src, char c)
        {
            var builder = build();
            foreach(var item in src)
            {
                builder.Append(item);
                builder.Append(c);
            }
            return builder.ToString();
        }

        /// <summary>
        /// Creates a new string by weaving a substring between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="sep">The value to intersperse</param>
        public static string Intersperse(this string src, string sep)
        {
            var builder = build();
            foreach(var item in src)
            {
                builder.Append(item);
                builder.Append(sep);
            }
            return builder.ToString();
        }
    }
}