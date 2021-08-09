//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class text
    {
        [Op, Closures(Closure)]
        public static void parse<T>(in TextGrid src, Span<T> dst, Func<TextRow,T> parser)
        {
            var rows = src.RowData.View;
            var count = rows.Length;
            for(var i=0; i<count; i++)
               seek(dst,i) = parser(skip(rows,i));
        }
    }
}