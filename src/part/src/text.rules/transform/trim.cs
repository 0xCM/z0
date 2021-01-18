//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;

    partial struct TextRules
    {
        partial struct Transform
        {
            [MethodImpl(Inline), Op]
            public static string trim(string src)
                => src.Trim();

            [MethodImpl(Inline), Op]
            public static string trim(string src, char match)
                => src.Trim(match);

            [MethodImpl(Inline), Op]
            public static string trim(string src, char[] matches)
                => src.Trim(matches);

            [Op]
            public static IEnumerable<string> trim(IEnumerable<string> src)
                => src.Select(s => s.Trim());

            [Op]
            public static IEnumerable<string> trim(IEnumerable<string> src, char match)
                => src.Select(s => s.Trim(match));

            [Op]
            public static IEnumerable<string> trim(IEnumerable<string> src, char[] matches)
                => src.Select(s => s.Trim(matches));

            [Op]
            public static string[] trim(string[] src)
                => src.Select(s => s.Trim());

            [Op]
            public static string[] trim(string[] src, char match)
                => src.Select(s => s.Trim(match));

            [Op]
            public static string[] trim(string[] src, char[] matches)
                => src.Select(s => s.Trim(matches));
        }
    }
}