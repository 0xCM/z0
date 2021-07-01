//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    partial struct TextTools
    {
        [Op, Closures(Closure)]
        public static void parse<T>(TextGrid src, Span<T> dst, Func<TextRow,T> parser)
        {
            var rows = src.RowData.View;
            var count = rows.Length;
            for(var i=0; i<count; i++)
               seek(dst,i) = parser(skip(rows,i));
        }
    }
}