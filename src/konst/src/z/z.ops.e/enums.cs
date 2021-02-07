//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<sbyte> src)
            where E : unmanaged, Enum
                => recover<sbyte,E>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<byte> src)
            where E : unmanaged, Enum
                => recover<byte,E>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<short> src)
            where E : unmanaged, Enum
                => recover<short,E>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<ushort> src)
            where E : unmanaged, Enum
                => recover<ushort,E>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<int> src)
            where E : unmanaged, Enum
                => recover<int,E>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<uint> src)
            where E : unmanaged, Enum
                => recover<uint,E>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<long> src)
            where E : unmanaged, Enum
                => recover<long,E>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<ulong> src)
            where E : unmanaged, Enum
                => recover<ulong,E>(src);
    }
}