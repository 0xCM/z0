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
        public static IndexedBits<T,S,I> index<T,S,I>(T data, ReadOnlySpan<byte> positions, ReadOnlySpan<byte> widths)
            where T : unmanaged
            where S : unmanaged
            where I : unmanaged
                => new IndexedBits<T,S,I>(data, positions, widths);

        [MethodImpl(Inline)]
        public static IndexedBits<T,S,I> index<T,S,I>(T data, ReadOnlySpan<I> positions, ReadOnlySpan<byte> widths)
            where T : unmanaged
            where S : unmanaged
            where I : unmanaged
                => new IndexedBits<T,S,I>(data, recover<I,byte>(positions), widths);

        [MethodImpl(Inline)]
        public static IndexedBits<T,S,I> index<T,S,I>(T data, ReadOnlySpan<I> positions, ReadOnlySpan<S> widths)
            where T : unmanaged
            where S : unmanaged
            where I : unmanaged
                => new IndexedBits<T,S,I>(data, recover<I,byte>(positions), recover<S,byte>(widths));

        [MethodImpl(Inline)]
        public static IndexedBits<T,S,I> index<T,S,I>(T data)
            where T : unmanaged
            where S : unmanaged, Enum
            where I : unmanaged, Enum
                => new IndexedBits<T,S,I>(data, recover<I,byte>(ClrEnums.literals<I>()), recover<S,byte>(ClrEnums.literals<S>()));

        [MethodImpl(Inline), Op]
        public static IndexedBits<byte,byte,byte> index(byte data, ReadOnlySpan<byte> positions, ReadOnlySpan<byte> widths)
            => index<byte,byte,byte>(data, positions, widths);

        [MethodImpl(Inline), Op]
        public static IndexedBits<ushort,ushort,byte> index(ushort data, ReadOnlySpan<byte> positions, ReadOnlySpan<byte> widths)
            => index<ushort,ushort,byte>(data, positions, widths);

        [MethodImpl(Inline), Op]
        public static IndexedBits<uint,uint,byte> index(uint data, ReadOnlySpan<byte> positions, ReadOnlySpan<byte> widths)
            => index<uint,uint,byte>(data, positions, widths);

        [MethodImpl(Inline), Op]
        public static IndexedBits<ulong,ulong,byte> index(ulong data, ReadOnlySpan<byte> positions, ReadOnlySpan<byte> widths)
            => index<ulong,ulong,byte>(data, positions, widths);
    }
}