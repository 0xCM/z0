//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using C = AsciCharCode;

    partial struct TextRules
    {
        partial struct Query
        {
            /// <summary>
            /// Determines whether an asci code defines the <see cref='Chars.RBrace'/> character
            /// </summary>
            /// <param name="src">The value to test</param>
            [MethodImpl(Inline), Op]
            public static bit rbrace(C src)
                => src == C.RBrace;

            /// <summary>
            /// Determines whether an asci code defines the <see cref='Chars.RBrace'/> character
            /// </summary>
            /// <param name="src">The value to test</param>
            [MethodImpl(Inline), Op]
            public static bit rbrace(char src)
                => rbrace((C)src);
        }
    }
}