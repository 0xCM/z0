//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Text;

    using static Part;
    using static memory;

    partial struct TextRules
    {
        partial struct Format
        {
           [Op]
            public static string nest(params object[] src)
                => text.format(RP.SSx5,
                    FieldDelimiter,
                    NestedLeftFence,
                    text.concat(src.Select(x => delimit(src, FieldDelimiter))),
                    NestedRightFence,
                    FieldDelimiter
                    );

            const char NestedLeftFence = Chars.LBrace;

            const char NestedRightFence = Chars.RBrace;
        }
    }
}