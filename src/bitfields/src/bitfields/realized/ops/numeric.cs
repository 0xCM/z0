//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct BitFields
    {
        [MethodImpl(Inline)]
        public static IndexedBits<T,S,I> numeric<T,S,I>(T data, ReadOnlySpan<byte> positions, ReadOnlySpan<byte> widths)
            where T : unmanaged
            where S : unmanaged
            where I : unmanaged
                => new IndexedBits<T,S,I>(data, positions, widths);

        [MethodImpl(Inline)]
        public static IndexedBits<T,S,I> numeric<T,S,I>(T data, ReadOnlySpan<I> positions, ReadOnlySpan<byte> widths)
            where T : unmanaged
            where S : unmanaged
            where I : unmanaged
                => new IndexedBits<T,S,I>(data, recover<I,byte>(positions), widths);

        [MethodImpl(Inline)]
        public static IndexedBits<T,S,I> numeric<T,S,I>(T data, ReadOnlySpan<I> positions, ReadOnlySpan<S> widths)
            where T : unmanaged
            where S : unmanaged
            where I : unmanaged
                => new IndexedBits<T,S,I>(data, recover<I,byte>(positions), recover<S,byte>(widths));

        [MethodImpl(Inline)]
        public static IndexedBits<T,S,I> numeric<T,S,I>(T data)
            where T : unmanaged
            where S : unmanaged, Enum
            where I : unmanaged, Enum
                => new IndexedBits<T,S,I>(data, recover<I,byte>(ClrEnums.literals<I>()), recover<S,byte>(ClrEnums.literals<S>()));

        [MethodImpl(Inline), Op]
        public static IndexedBits<byte,byte,byte> numeric(byte data, ReadOnlySpan<byte> positions, ReadOnlySpan<byte> widths)
            => numeric<byte,byte,byte>(data, positions, widths);

        [MethodImpl(Inline), Op]
        public static IndexedBits<ushort,ushort,byte> numeric(ushort data, ReadOnlySpan<byte> positions, ReadOnlySpan<byte> widths)
            => numeric<ushort,ushort,byte>(data, positions, widths);

        [MethodImpl(Inline), Op]
        public static IndexedBits<uint,uint,byte> numeric(uint data, ReadOnlySpan<byte> positions, ReadOnlySpan<byte> widths)
            => numeric<uint,uint,byte>(data, positions, widths);

        [MethodImpl(Inline), Op]
        public static IndexedBits<ulong,ulong,byte> numeric(ulong data, ReadOnlySpan<byte> positions, ReadOnlySpan<byte> widths)
            => numeric<ulong,ulong,byte>(data, positions, widths);
    }
}