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
        partial struct Test
        {
            /// <summary>
            /// Tests whether the source string is either null or of zero length
            /// </summary>
            /// <param name="src">The string to test</param>
            [MethodImpl(Inline), Op]
            public static bool empty(string src)
                => string.IsNullOrEmpty(src);

            /// <summary>
            /// Tests whether the source string is nonempty
            /// </summary>
            /// <param name="src">The string to evaluate</param>
            [MethodImpl(Inline), Op]
            public static bool nonempty(string src)
                => !string.IsNullOrEmpty(src);
        }
    }
}