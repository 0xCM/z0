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

    [ApiHost]
    public readonly struct Tables
    {
        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>()
            where F : unmanaged, Enum
            => new TableFormatter<F>(new StringBuilder(), FieldDelimiter);

        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>(char delimiter)
            where F : unmanaged, Enum
            => new TableFormatter<F>(new StringBuilder(), delimiter);

        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>(StringBuilder dst, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new TableFormatter<F>(dst, delimiter);    
    }
}