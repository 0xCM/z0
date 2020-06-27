//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct As
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<sbyte> src)
            where E : unmanaged, Enum
                => cast<sbyte,E>(src); 

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<byte> src)
            where E : unmanaged, Enum
                => cast<byte,E>(src); 

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<short> src)
            where E : unmanaged, Enum
                => cast<short,E>(src); 

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<ushort> src)
            where E : unmanaged, Enum
                => cast<ushort,E>(src); 

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<int> src)
            where E : unmanaged, Enum
                => cast<int,E>(src); 

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<uint> src)
            where E : unmanaged, Enum
                => cast<uint,E>(src); 

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<long> src)
            where E : unmanaged, Enum
                => cast<long,E>(src); 

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<ulong> src)
            where E : unmanaged, Enum
                => cast<ulong,E>(src); 

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<E> enums<E>(ReadOnlySpan<decimal> src)
            where E : unmanaged, Enum
                => cast<decimal,E>(src); 

    }
}