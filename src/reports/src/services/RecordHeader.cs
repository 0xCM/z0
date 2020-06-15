//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;   

    public readonly struct RecordHeader
    {
        [MethodImpl(Inline)]
        public static string format<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => TabularFormats.derive<F>(delimiter).FormatHeader();

        [MethodImpl(Inline)]
        public static RecordHeader<F> define<F>()
            where F : unmanaged, Enum
                => default;
    }
}