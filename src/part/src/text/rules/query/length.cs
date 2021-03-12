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
        partial struct Query
        {
            /// <summary>
            /// Determines the length of a specified <see cref='string'/>
            /// </summary>
            /// <param name="src">The source text</param>
            [MethodImpl(Inline), Op]
            public static int length(string src)
                => src?.Length ?? 0;
        }
    }
}