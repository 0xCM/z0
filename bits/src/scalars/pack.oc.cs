//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class bvoc
    {
        public static ulong pack8(Span<bit> src)
            => Bits.pack(n8, src);

        public static BitVector<byte> pack8g(Span<bit> src)
            => gbits.pack<byte>(src);

        public static ulong pack16(Span<bit> src)
            => Bits.pack(n16, src);

        public static BitVector<ushort> pack16g(Span<bit> src)
            => gbits.pack<ushort>(src);

        public static ulong pack32(Span<bit> src)
            => Bits.pack(n32, src);

        public static BitVector<uint> pack32g(Span<bit> src)
            => gbits.pack<uint>(src);

        public static BitVector<ulong> pack64g(Span<bit> src)
            => gbits.pack<ulong>(src);

        public static ulong pack64(Span<bit> src)
            => Bits.pack(n64, src);

        public static uint pop_4x64(ulong x0, ulong x1, ulong x2, ulong x3)
            => gbits.pop(x0,x1,x2,x3);

        public static uint pop_8x64(ulong x0, ulong x1, ulong x2, ulong x3, ulong x4, ulong x5, ulong x6, ulong x7)
            => gbits.pop(x0,x1,x2,x3,x4,x5,x6,x7);

    }

}