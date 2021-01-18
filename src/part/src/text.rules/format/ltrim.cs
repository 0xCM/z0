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

    partial struct TextRules
    {
        partial struct Format
        {
            /// <summary>
            /// Trims leading characters when matched
            /// </summary>
            /// <param name="src">The text to manipulate</param>
            /// <param name="chars">The leading characters to remove</param>
            [MethodImpl(Options), Op]
            public static string ltrim(string src, params char[] chars)
                => Query.blank(src) ? string.Empty : src.TrimStart(chars);

            /// <summary>
            /// Trims trailing characters when matched
            /// </summary>
            /// <param name="src">The text to manipulate</param>
            /// <param name="chars">The leading characters to remove</param>
            [MethodImpl(Options), Op]
            public static string rtrim(string src, params char[] chars)
                => Query.blank(src) ? string.Empty : src.TrimEnd(chars);
        }
    }
}