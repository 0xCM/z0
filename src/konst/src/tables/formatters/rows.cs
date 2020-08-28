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

    using NK = EnumTypeCode;

    partial struct TableFormat
    {
        [MethodImpl(Inline)]
        public static RowFormatter<T> rows<T>(TableFields fields, StringBuilder dst, char delimiter = FieldDelimiter)
            where T : struct
                => new RowFormatter<T>(fields, dst, FieldDelimiter);

        [MethodImpl(Inline)]
        public static RowFormatter<T> rows<T>(TableFields fields, char delimiter = FieldDelimiter)
            where T : struct
                => new RowFormatter<T>(fields, text.build(), FieldDelimiter);

        [MethodImpl(Inline)]
        public static RowFormatter<T> rows<T>(char delimiter = FieldDelimiter)
            where T : struct
                => new RowFormatter<T>(Table.fields<T>(), text.build(), FieldDelimiter);
    }
}