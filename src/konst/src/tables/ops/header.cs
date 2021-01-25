//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct Table
    {
        public static TableHeader<F> header<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new TableHeader<F>(ClrLiteralFields.values<F>());
        [Op]
        public static string header53<T>(char delimiter = FieldDelimiter)
            where T : unmanaged, Enum
                => Table.datasetHeader<T>().Render(delimiter);

        [MethodImpl(Inline)]
        public static DatasetHeader<F> datasetHeader<F>()
            where F : unmanaged, Enum
                => new DatasetHeader<F>();

        [MethodImpl(Inline)]
        public static string headerText<E>(char delimiter = FieldDelimiter)
            where E : unmanaged, Enum
                => header(columns<E>(), delimiter);
        [Op]
        public static string header(ReadOnlySpan<TableColumn> columns, char delimiter = FieldDelimiter)
        {
            var dst = text.build();
            var count = columns.Length;
            for(var i=0u; i<count; i++)
            {
                dst.Append(delimiter);
                dst.Append(Space);

                ref readonly var field = ref skip(columns,i);
                var name = field.Name.Format();
                if(i != count - 1)
                    dst.Append(name.PadRight(field.Width));
                else
                    dst.Append(name);
            }
            return dst.ToString();
        }
    }
}