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
        /// <summary>
        /// Derives format configuration data from a type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        public static TableRenderSpec<F> renderspec<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
        {
            var literals = @readonly(index<F>().Literals);
            var count = literals.Length;
            var headBuffer = sys.alloc<string>(count);
            var fieldBuffer = sys.alloc<TabularField<F>>(count);
            var fields = span(fieldBuffer);

            for(var i=0u; i<count; i++)
            {
                ref readonly var literal = ref skip(literals, i);
                seek(fields,i) = new TabularField<F>(literal, literal.ToString(), (int)i, (short)(uint32(literal) >> WidthOffset));
            }

            return new TableRenderSpec<F>(fieldBuffer);
        }

        [MethodImpl(Inline)]
        public static RecordFormatter<F,W> formatter<F,W>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
            where W : unmanaged, Enum
                => new RecordFormatter<F,W>(text.build(), delimiter);

        [MethodImpl(Inline)]
        public static RowFormatter formatter(Type table, char delimiter = FieldDelimiter)
            => new RowFormatter(table, fields(table), text.build(), delimiter);

        [MethodImpl(Inline)]
        public static RowFormatter formatter(Type table, StringBuilder dst, char delimiter = FieldDelimiter)
            => new RowFormatter(table, fields(table), dst, delimiter);

        [MethodImpl(Inline)]
        public static RowFormatter<T> formatter<T>(TableFields fields, StringBuilder dst, char delimiter = FieldDelimiter)
            where T : struct
                => new RowFormatter<T>(fields, dst, FieldDelimiter);

        [MethodImpl(Inline)]
        public static RowFormatter<T> formatter<T>(TableFields fields, char delimiter = FieldDelimiter)
            where T : struct
                => new RowFormatter<T>(fields, text.build(), FieldDelimiter);

        [MethodImpl(Inline)]
        public static RowFormatter<T> rowformatter<T>(char delimiter = FieldDelimiter)
            where T : struct
                => new RowFormatter<T>(fields<T>(), text.build(), FieldDelimiter);

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