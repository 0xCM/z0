//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct TextRules
    {
        partial struct Parse
        {
            /// <summary>
            /// If bracketed, extracts the enclosed content; otherwise, returns the empty string
            /// </summary>
            /// <param name="src">The source text</param>
            [Op]
            public static Outcome<string> unbracket(string src)
                => unfence(src, Chars.LBracket, Chars.RBracket);
        }
    }
}