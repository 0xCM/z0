//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static TextRules;

    partial struct TextFormat
    {
        /// <summary>
        /// Trims leading characters when matched
        /// </summary>
        /// <param name="src">The text to manipulate</param>
        /// <param name="chars">The leading characters to remove</param>
        [Op]
        public static string ltrim(string src, params char[] chars)
            => Query.blank(src) ? EmptyString : src.TrimStart(chars);

        /// <summary>
        /// Trims trailing characters when matched
        /// </summary>
        /// <param name="src">The text to manipulate</param>
        /// <param name="chars">The leading characters to remove</param>
        [Op]
        public static string rtrim(string src, params char[] chars)
            => Query.blank(src) ? EmptyString : src.TrimEnd(chars);
    }
}