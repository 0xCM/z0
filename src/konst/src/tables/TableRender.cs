//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct TableRender
    {

    }

    [ApiHost]
    public readonly partial struct TableFormatter
    {

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static RowFormatter<T> row<T>(ReadOnlySpan<byte> widths, T t = default, char delimiter = FieldDelimiter)
            where T : struct
                => new RowFormatter<T>(Table.fields<T>(widths), text.build(), FieldDelimiter);
    }
}
