//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static RecordFormatter<F,W> formatter<F,W>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
            where W : unmanaged, Enum
                => new RecordFormatter<F,W>(text.build(), delimiter);

        [Op, Closures(UnsignedInts)]
        public static TableFormatter<F> formatter<F>(in LiteralFieldValues<F> fields, StringBuilder dst, char delimiter)
            where F : unmanaged
                => new TableFormatter<F>(dst, delimiter, fields);

        [Op, Closures(UnsignedInts)]
        public static TableFormatter<F> formatter<F>(F f = default)
            where F : unmanaged
                => new TableFormatter<F>(text.build(), FieldDelimiter, LiteralFields.fields<F>());

        [Op, Closures(UnsignedInts)]
        public static TableFormatter<F> formatter<F>(in LiteralFieldValues<F> fields, char delimiter = FieldDelimiter)
            where F : unmanaged
                => new TableFormatter<F>(text.build(), delimiter, fields);

        [MethodImpl(Inline)]
        public static FieldFormatter<F> formatter<F>(char delimiter, F f = default)
            where F : unmanaged, Enum
                => new FieldFormatter<F>(text.build(), delimiter);
    }
}