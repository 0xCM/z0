//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct TableRender
    {

    }


    [ApiHost]
    public readonly partial struct TableFormatter
    {
        [MethodImpl(Inline), Op]
        public static RowFormatter row(Type table, char delimiter = FieldDelimiter)
            => new RowFormatter(table, Table.index(table), text.build(), delimiter);

        [MethodImpl(Inline), Op]
        public static RowFormatter row(Type table, StringBuilder dst, char delimiter = FieldDelimiter)
            => new RowFormatter(table, Table.index(table), dst, delimiter);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static RowFormatter<T> row<T>(char delimiter = FieldDelimiter)
            where T : struct
                => new RowFormatter<T>(Table.index<T>(), text.build(), FieldDelimiter);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static RowFormatter<T> row<T>(ReadOnlySpan<byte> widths, T t = default, char delimiter = FieldDelimiter)
            where T : struct
                => new RowFormatter<T>(Table.index<T>(widths), text.build(), FieldDelimiter);
    }
}
