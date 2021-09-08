//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        [MethodImpl(Inline), Op]
        public static gbv<ByteBlock8> bv(uint n, ByteBlock8 src)
            => new gbv<ByteBlock8>(n, src);

        [MethodImpl(Inline), Op]
        public static gbv<ByteBlock16> bv(uint n, ByteBlock16 src)
            => new gbv<ByteBlock16>(n, src);

        [MethodImpl(Inline), Op]
        public static gbv<ByteBlock32> bv(uint n, ByteBlock32 src)
            => new gbv<ByteBlock32>(n, src);

        [MethodImpl(Inline), Op]
        public static gbv<ByteBlock64> bv(uint n, ByteBlock64 src)
            => new gbv<ByteBlock64>(n, src);

        [MethodImpl(Inline), Op]
        public static gbv<ByteBlock128> bv(uint n, ByteBlock128 src)
            => new gbv<ByteBlock128>(n, src);
    }
}