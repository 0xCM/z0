//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

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
    }
}