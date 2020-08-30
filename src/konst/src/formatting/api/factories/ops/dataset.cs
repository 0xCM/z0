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

    partial struct Formatters
    {
        [MethodImpl(Inline)]
        public static DatasetFormatter<F> dataset<F>()
            where F : unmanaged, Enum
                => new DatasetFormatter<F>(text.build());

        [MethodImpl(Inline)]
        public static DatasetFormatter<F> dataset<F>(char delimiter)
            where F : unmanaged, Enum
                => new DatasetFormatter<F>(text.build(), delimiter);

        [MethodImpl(Inline)]
        public static DatasetFormatter<F> dataset<F>(StringBuilder dst, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new DatasetFormatter<F>(dst, delimiter);
    }
}