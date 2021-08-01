//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.BZ;

    using static Root;
    using static core;

    partial struct Blit
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bv<T> bv<T>(uint width, T src)
            where T : unmanaged
                => new bv<T>(width, src);

        [MethodImpl(Inline), Op]
        public static bv1 bv1(byte src)
            => new bv1(src);

        [MethodImpl(Inline), Op]
        public static bv2 bv2(byte src)
            => new bv2(src);

        [MethodImpl(Inline), Op]
        public static bv3 bv3(byte src)
            => new bv3(src);

        [MethodImpl(Inline), Op]
        public static bv4 bv4(byte src)
            => new bv4(src);

        [MethodImpl(Inline), Op]
        public static bv5 bv5(byte src)
            => new bv5(src);

        [MethodImpl(Inline), Op]
        public static bv6 bv6(byte src)
            => new bv6(src);

        [MethodImpl(Inline), Op]
        public static bv7 bv7(byte src)
            => new bv7(src);

        [MethodImpl(Inline), Op]
        public static bv8 bv8(byte src)
            => new bv8(src);

        [MethodImpl(Inline), Op]
        public static bv16 bv16(ushort src)
            => new bv16(src);

        [MethodImpl(Inline), Op]
        public static bv32 bv32(uint src)
            => new bv32(src);

        [MethodImpl(Inline), Op]
        public static bv64 bv64(ulong src)
            => new bv64(src);

        [MethodImpl(Inline), Op]
        public static bv<Cell128> bv128(uint width, Cell128 src)
            => bv<Cell128>(width, src);

        [MethodImpl(Inline), Op]
        public static bv<Cell256> bv256(uint width, Cell256 src)
            => bv<Cell256>(width, src);

        [Op]
        public static bv<Cell512> bv512(uint width, Cell512 src)
            => bv<Cell512>(width, src);
    }
}