//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct TextRules
    {
        partial struct Test
        {
            /// <summary>
            /// Determines whether the source text is of the form "[{content}]"
            /// </summary>
            /// <param name="src">The source text</param>
            [Op]
            public static bool bracketed(string src)
                => fenced(src, Chars.LBracket, Chars.RBracket);
        }
    }
}