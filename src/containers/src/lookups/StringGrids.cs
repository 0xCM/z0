//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    [ApiHost]
    public readonly struct StringGrids
    {
        public static StringGrid create(ushort rows, ushort cols)
            => StringGrid.create(rows,cols);

        [MethodImpl(Inline), Op]
        public ref string entry(StringGrid src, ushort row, ushort col)
        {
            return ref src.Data[row,col];
        }
    }
}