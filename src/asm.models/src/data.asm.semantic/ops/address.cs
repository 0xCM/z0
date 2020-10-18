//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct AsmSemantic
    {
        [MethodImpl(Inline)]
        public static RelativeAddress<BW,RW,B,R> address<BW,RW,B,R>(B @base, R offset, BW bw = default, RW rw = default)
            where BW: unmanaged, INumericWidth
            where RW: unmanaged, INumericWidth
            where B: unmanaged
            where R: unmanaged
                => new RelativeAddress<BW,RW,B,R>(@base, offset);

        [MethodImpl(Inline), Op]
        public static RelativeAddress<W32,W16,uint,ushort> address(uint @base, ushort offset)
            => address(@base, offset, w32, w16);

        [MethodImpl(Inline), Op]
        public static RelativeAddress<W64,W8,ulong,byte> address(ulong @base, byte offset)
            => address(@base, offset, w64, w8);

        [MethodImpl(Inline), Op]
        public static RelativeAddress<W64,W16,ulong,ushort> address(ulong @base, ushort offset)
            => address(@base, offset, w64, w16);

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