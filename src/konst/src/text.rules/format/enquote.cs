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
            /// <summary>
            /// Encloses text in quotation marks if nonempty; otherwise returns empty
            /// </summary>
            /// <param name="src">The text to be quoted</param>
            [MethodImpl(Inline), Op]
            public static string enquote(string src)
            {
                if(!string.IsNullOrWhiteSpace(src))
                    return concat(Chars.Quote, src, Chars.Quote);
                else
                    return string.Empty;
            }
        }
    }
}