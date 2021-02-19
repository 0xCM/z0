//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static TextRules;

    partial class XText
    {
        /// <summary>
        /// Formats a readonly span as a vector
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        [TextUtility, Closures(Closure)]
        public static string FormatVector<T>(this ReadOnlySpan<T> src, char sep = Chars.Comma)
        {
            var body = src.Map(x => x.ToString()).Join(sep);
            return Format.enclose(body, Rules.fence(Chars.Lt, Chars.Gt));
        }

        /// <summary>
        /// Formats a span as a vector
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        [TextUtility, Closures(Closure)]
        public static string FormatVector<T>(this Span<T> src, char sep = Chars.Comma)
            => src.ReadOnly().FormatVector(sep);
    }
}