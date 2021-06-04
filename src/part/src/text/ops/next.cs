//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class text
    {
        [Op]
        public static string nest(params object[] src)
            => string.Format(RP.SSx5,
                FieldDelimiter,
                Chars.LBrace,
                string.Concat(src.Select(x => TextTools.delimit(src, FieldDelimiter))),
                Chars.RBrace,
                FieldDelimiter
                );
    }
}