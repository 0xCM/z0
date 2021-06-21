//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    [ApiHost]
    public readonly struct StringGrids
    {
        public static StringGrid create(ushort rows, ushort cols)
            => StringGrid.create(rows,cols);

        [MethodImpl(Inline), Op]
        public static ref string entry(StringGrid src, ushort row, ushort col)
            => ref src.Data[row,col];

        [MethodImpl(Inline), Op]
        public static void row(StringGrid src, ushort row, ReadOnlySpan<string> cols)
        {
            var count = min(src.ColCount, cols.Length);
            for(ushort i=0; i<count; i++)
                entry(src, row, i) = skip(cols, i);
        }
    }
}