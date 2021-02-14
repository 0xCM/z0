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
        }
    }
}