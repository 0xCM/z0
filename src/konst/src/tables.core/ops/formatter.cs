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

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static RecordFormatter<F,W> formatter<F,W>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
            where W : unmanaged, Enum
                => new RecordFormatter<F,W>(text.build(), delimiter);

        [MethodImpl(Inline), Op]
        public static RowFormatter formatter(Type table, char delimiter = FieldDelimiter)
            => new RowFormatter(table, fields(table), text.build(), delimiter);

        [MethodImpl(Inline), Op]
        public static RowFormatter formatter(Type table, StringBuilder dst, char delimiter = FieldDelimiter)
            => new RowFormatter(table, fields(table), dst, delimiter);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static RowFormatter<T> rowformatter<T>(char delimiter = FieldDelimiter)
            where T : struct
                => new RowFormatter<T>(fields<T>(), text.build(), FieldDelimiter);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static RowFormatter<T> rowformatter<T>(ReadOnlySpan<byte> widths, T t = default, char delimiter = FieldDelimiter)
            where T : struct
                => new RowFormatter<T>(fields<T>(widths), text.build(), FieldDelimiter);

        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>(in LiteralFields<F> fields, StringBuilder dst, char delimiter)
            where F : unmanaged, Enum
                => new TableFormatter<F>(dst, delimiter, fields);

        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>(F f = default)
            where F : unmanaged, Enum
                => new TableFormatter<F>(text.build(), FieldDelimiter, Literals.fields<F>());

        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>(in LiteralFields<F> fields, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new TableFormatter<F>(text.build(), delimiter, fields);

        [MethodImpl(Inline)]
        public static FieldFormatter<F> formatter<F>(char delimiter, F f = default)
            where F : unmanaged, Enum
                => new FieldFormatter<F>(text.build(), delimiter);
    }
}