//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct TextRules
    {
        partial struct Format
        {
            /// <summary>
            /// Formats a character span
            /// </summary>
            /// <param name="src"></param>
            [Op]
            public static string format(ReadOnlySpan<char> src)
                => new string(src);

            [Op]
            public static string format(string pattern, ReadOnlySpan<char> a0)
                => string.Format(pattern, a0.ToString());

            [Op]
            public static string format(string pattern, ReadOnlySpan<char> a0, ReadOnlySpan<char> a1)
                => string.Format(pattern, a0.ToString(), a1.ToString());

            [Op]
            public static string format(string pattern, ReadOnlySpan<char> a0, ReadOnlySpan<char> a1, ReadOnlySpan<char> a2)
                => string.Format(pattern, a0.ToString(), a1.ToString(), a2.ToString());

        }
    }
}