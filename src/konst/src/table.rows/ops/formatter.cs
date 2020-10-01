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

    partial struct TableRows
    {
        [MethodImpl(Inline), Op]
        public static RowFormatter formatter(Type table, char delimiter = FieldDelimiter)
            => new RowFormatter(table, TableFields.index(table), text.build(), delimiter);

        [MethodImpl(Inline), Op]
        public static RowFormatter formatter(Type table, StringBuilder dst, char delimiter = FieldDelimiter)
            => new RowFormatter(table, TableFields.index(table), dst, delimiter);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static RowFormatter<T> formatter<T>(char delimiter = FieldDelimiter)
            where T : struct
                => new RowFormatter<T>(TableFields.index<T>(), text.build(), FieldDelimiter);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static RowFormatter<T> formatter<T>(ReadOnlySpan<byte> widths, T t = default, char delimiter = FieldDelimiter)
            where T : struct
                => new RowFormatter<T>(TableFields.index<T>(widths), text.build(), FieldDelimiter);
    }
}