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
            [MethodImpl(Inline), Op]
            public static string substring(string src, int start)
                => sys.substring(src, start);

            [MethodImpl(Inline), Op]
            public static string substring(string src, int start, int len)
                => sys.substring(src, start, len);
        }
    }
}