//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Rules;
    using static memory;

    partial struct TextRules
    {
        partial struct Query
        {
            [MethodImpl(Inline), Op]
            public static bool begins(string src, char match)
                => length(src) != 0 && src[0] == match;

            [MethodImpl(Inline), Op]
            public static bool begins(string src, string match)
                => length(src) != 0 && src.StartsWith(match);
        }
    }
}