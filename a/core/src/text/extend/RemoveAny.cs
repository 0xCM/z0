//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    partial class XTend
    {
        /// <summary>
        /// Erases a specified set of character occurrences in a string
        /// </summary>
        /// <param name="s">The string to manipulate</param>
        /// <param name="removals">The characters to remove</param>
        public static string RemoveAny(this string s, IEnumerable<char> removals)
        {
            if (s.ContainsAny(removals))
            {
                var dst = String.Empty;
                var src = s.ToCharArray();
                for (int i = 0; i < s.Length; i++)
                    if (!removals.Contains(src[i]))
                        dst += src[i];
                return dst;
            }
            else
                return s;
        }

        /// <summary>
        /// Erases a specified set of character occurrences in a string
        /// </summary>
        /// <param name="s">The string to manipulate</param>
        /// <param name="removals">The characters to remove</param>
        public static string RemoveAny(this string s, params char[] removals)
            => s.RemoveAny(removals as IEnumerable<char>);
    }
}