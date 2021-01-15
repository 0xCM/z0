//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;

    [ApiHost(ApiNames.TextApi, true)]
    readonly partial struct text
    {
        const MethodImplOptions Options = NotInline;

        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Options), Op]
        public static bool blank(string src)
            => string.IsNullOrWhiteSpace(src);

        [MethodImpl(Options), Op]
        public static int compare(string a, string b)
            => a?.CompareTo(b) ?? 0;

        /// <summary>
        /// Trims leading characters when matched
        /// </summary>
        /// <param name="src">The text to manipulate</param>
        /// <param name="chars">The leading characters to remove</param>
        [MethodImpl(Options), Op]
        public static string ltrim(string src, params char[] chars)
            => blank(src) ? string.Empty : src.TrimStart(chars);

        /// <summary>
        /// Trims trailing characters when matched
        /// </summary>
        /// <param name="src">The text to manipulate</param>
        /// <param name="chars">The leading characters to remove</param>
        [MethodImpl(Options), Op]
        public static string rtrim(string src, params char[] chars)
            => blank(src) ? string.Empty : src.TrimEnd(chars);

        /// <summary>
        /// Joins the string representation of a sequence of items with no interspersed separator
        /// </summary>
        /// <param name="src">The values to be joined</param>
        [MethodImpl(Inline), Op]
        public static string concat(params object[] src)
            => string.Concat(src);

        [Op]
        public static ITextBuffer buffer()
            => new TextBuffer(new StringBuilder());
    }
}