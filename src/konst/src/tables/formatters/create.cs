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

    partial struct TableFormat
    {
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