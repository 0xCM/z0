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
        partial struct Factory
        {
            /// <summary>
            /// Creates a <see cref='TextBlock'/>
            /// </summary>
            /// <param name="src">The source text</param>
            [MethodImpl(Inline), Op]
            public static TextBlock block(string src)
                => new TextBlock(src);
        }
    }
}