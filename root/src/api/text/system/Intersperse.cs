//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;

    partial class TextExtensions
    {
        /// <summary>
        /// Creates a new string by weaving a specified character between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="c">The character to intersperse</param>
        public static string Intersperse(this string src, char c)
        {
            var sb = new StringBuilder();
            foreach(var item in src)
            {
                sb.Append(item);
                sb.Append(c);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Creates a new string by weaving a substring between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="sep">The value to intersperse</param>
        public static string Intersperse(this string src, string sep)
        {
            var sb = new StringBuilder();
            foreach(var item in src)
            {
                sb.Append(item);
                sb.Append(sep);
            }
            return sb.ToString();
        }


    }

}