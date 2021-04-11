//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static TextRules;

    partial class text
    {
        [Op]
        public static string nest(params object[] src)
            => text.format(RP.SSx5,
                FieldDelimiter,
                Chars.LBrace,
                text.concat(src.Select(x => text.delimit(src, FieldDelimiter))),
                Chars.RBrace,
                FieldDelimiter
                );
    }
}