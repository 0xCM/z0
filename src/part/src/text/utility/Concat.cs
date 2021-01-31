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

    using static TextRules;

    partial class XText
    {
        /// <summary>
        /// Joins the strings provided by the enumerable with an optional separator
        /// </summary>
        /// <param name="src">The source strings</param>
        /// <param name="sep">The separator, if any</param>
        [TextUtility]
        public static string Concat(this IEnumerable<string> src, string sep = null)
            => string.Join(sep ?? string.Empty, src);

        [TextUtility]
        public static string Concat(this IEnumerable<string> src, char sep)
            => string.Join(sep, src);

        [TextUtility]
        public static string Concat(this ReadOnlySpan<string> src, string sep = null)
            => text.concat(src,sep);

        [TextUtility]
        public static string Concat(this ReadOnlySpan<string> src, char? sep)
            => text.concat(src, sep);

        /// <summary>
        /// Joins a sequence of source characters interspersed with a supplied separator
        /// </summary>
        /// <param name="chars">The characters to join</param>
        /// <param name="sep">The character to intersperse</param>
        [TextUtility]
        public static string Concat(this IEnumerable<char> chars, char sep)
            => new string(chars.Intersperse(sep).ToSpan());

        /// <summary>
        /// Forms a string by source character juxtaposition
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        [TextUtility]
        public static string Concat(this IEnumerable<char> src)
            => new string(src.ToArray());

        /// <summary>
        /// Forms a string from a character array
        /// </summary>
        /// <param name="src">The source array</param>
        [TextUtility]
        public static string Concat(this char[] src)
            => new string(src);

        /// <summary>
        /// Forms a string by source character juxtaposition
        /// </summary>
        /// <param name="src">The source span</param>
        [TextUtility]
        public static string Concat(this ReadOnlySpan<char> src)
            => new string(src);

        /// <summary>
        /// Forms a string by source character juxtaposition
        /// </summary>
        /// <param name="src">The source span</param>
        [TextUtility]
        public static string Concat(this Span<char> src)
            => new string(src);

        /// <summary>
        /// Forms a string by source character juxtaposition
        /// </summary>
        /// <param name="src">The source span</param>
        [TextUtility]
        public static ReadOnlySpan<char> Concat(this ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs)
            => lhs.Concat() + rhs.Concat();

        [TextUtility]
        public static string Concat(this Span<string> src, string sep)
            => TextRules.Format.concat(src,sep);

        /// <summary>
        /// Sequentially concatenates each indexed cell to the next without deimiters/interspersal
        /// </summary>
        /// <param name="src">The source text</param>
        [TextUtility]
        public static string Concat(this Span<string> src)
            => src.Concat(string.Empty);

        /// <summary>
        /// Sequentially concatenates each indexed cell to the next, separated by a specified character
        /// </summary>
        /// <param name="src">The source text</param>
        [TextUtility]
        public static string Concat(this Span<string> src, char sep)
            => src.Concat(sep.ToString());
    }
}