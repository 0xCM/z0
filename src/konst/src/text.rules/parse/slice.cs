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
        partial struct Parse
        {
            /// <summary>
            /// Extracts a substring
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="offset">The index of the first character</param>
            [MethodImpl(Inline), Op]
            public static string slice(string src, int offset)
                => src.Substring(offset);

            /// <summary>
            /// Extracts a substring
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="offset">The index of the first character</param>
            /// <param name="length">The substring length</param>
            [MethodImpl(Inline), Op]
            public static string slice(string src, int offset, int length)
                => src.Substring(offset, length);

            /// <summary>
            /// Extracts a substring beginning at a specified offset
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="offset">The index of the first character</param>
            /// <param name="length">The substring length</param>
            [MethodImpl(Inline), Op]
            public static string slice(string src, uint offset)
                => src.Substring((int)offset);

            /// <summary>
            /// Extracts a substring of specified length beginning at a specified offset
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="offset">The index of the first character</param>
            /// <param name="length">The substring length</param>
            [MethodImpl(Inline), Op]
            public static string slice(string src, uint offset, uint length)
                => src.Substring((int)offset, (int)length);
        }
    }
}