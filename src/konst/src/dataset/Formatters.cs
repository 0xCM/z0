//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Formatters
    {
        [MethodImpl(Inline)]
        public static FieldFormatter<F> fields<F>(StringBuilder buffer, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new FieldFormatter<F>(buffer,delimiter);

        [MethodImpl(Inline)]
        public static FieldFormatter<F> fields<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new FieldFormatter<F>(text.build(),delimiter);

        [MethodImpl(Inline)]
        public static DatasetFormatter<F> dataset<F>(StringBuilder buffer, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new DatasetFormatter<F>(buffer, delimiter);

        [MethodImpl(Inline)]
        public static DatasetFormatter<F> dataset<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new DatasetFormatter<F>(text.build(), delimiter);
    }
}