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
            [MethodImpl(Inline), Op]
            public static string rpad(string src, int width, char c = Space)
                => src.PadRight(width, c);
        }
    }
}