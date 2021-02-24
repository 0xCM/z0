//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static System.StringSplitOptions;

    partial struct TextRules
    {
        partial struct Parse
        {
            /// <summary>
            /// Splits the string, removing empty entries
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="sep">The delimiter</param>
            [Op]
            public static Index<string> split(string src, char sep, bool clean = true)
                => src.Split(sep,  clean ? RemoveEmptyEntries : None);

            /// <summary>
            /// Splits the string, removing empty entries
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="sep">The delimiter</param>
            [Op]
            public static Index<string> split(string src, string sep, bool clean = true)
                => src.Split(sep, clean ? RemoveEmptyEntries : None);
        }
    }
}