//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    using static Components;

    partial class XComponent
    {
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