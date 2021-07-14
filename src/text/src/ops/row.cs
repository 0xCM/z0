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
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> row(in AsciGrid src, ushort index)
        {
            var offset = index*(src.RowWidth + 2);
            return core.slice(src.Rows, offset, src.RowWidth);
        }
    }
}