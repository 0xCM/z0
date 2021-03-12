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
            /// Returns the substring [0,chars-1]
            /// </summary>
            [MethodImpl(Inline), Op]
            public static string left(string src, int chars)
                => Query.blank(src) ? src : substring(src, 0, src.Length < chars ? src.Length : chars);
        }
    }
}