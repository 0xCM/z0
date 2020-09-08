//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct EnumFormatters
    {
        [MethodImpl(Inline)]
        public static EnumFormatter<E> create<E>()
            where E : unmanaged, Enum
                => default;

        [MethodImpl(Inline)]
        public static string format<E>(E src)
            where E : unmanaged, Enum
                => create<E>().Format(src);
    }
}