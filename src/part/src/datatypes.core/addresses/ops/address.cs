//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly partial struct Addresses
    {
        [MethodImpl(Inline), Op]
        public static MemoryAddress memory(ulong src)
            => src;

        [MethodImpl(Inline), Op]
        public static Address8 address(byte src)
            => new Address8(src);

        [MethodImpl(Inline), Op]
        public static Address16 address(ushort src)
            => new Address16(src);

        [MethodImpl(Inline), Op]
        public static Address32 address(uint src)
            => new Address32(src);

        [MethodImpl(Inline), Op]
        public static Address64 address(ulong src)
            => new Address64(src);

        [MethodImpl(Inline), Op]
        public static Address<W8,byte> address(W8 w, byte src)
            => new Address<W8,byte>(src);

        [MethodImpl(Inline), Op]
        public static Address<W16,ushort> address(W16 w, ushort src)
            => new Address<W16,ushort>(src);

        [MethodImpl(Inline), Op]
        public static Address<W32,uint> address(W32 w, uint src)
            => new Address<W32,uint>(src);

        [MethodImpl(Inline), Op]
        public static Address<W64,ulong> address(W64 w, ulong src)
            => new Address<W64,ulong>(src);
    }
}

