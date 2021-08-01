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
        public static bv<ushort> bv16(uint width, ushort src)
            => bv<ushort>(width, src);

        [MethodImpl(Inline), Op]
        public static bv<uint> bv32(uint width, uint src)
            => bv<uint>(width, src);

        [MethodImpl(Inline), Op]
        public static bv<ulong> bv64(uint width, ulong src)
            => bv<ulong>(width, src);

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