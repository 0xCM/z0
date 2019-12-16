//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    


    public static class inxsoc
    {
        public static void unpack(byte src, in Block64<byte> dst)
            => ginxs.unpackbits(src,dst);

        public static void unpack(ushort src, in Block128<byte> dst)
            => ginxs.unpackbits(src,dst);

        public static uint pack64x8u(ConstBlock64<byte> src)
            => ginxs.bitpack(src);

        public static uint pack128x8u(ConstBlock128<byte> src)
            => ginxs.bitpack(src);

        public static uint pack_32u(ConstBlock256<byte> src)
            => ginxs.bitpack(src);

        public static void unpack_32u(uint src, Block256<byte> dst)
            => ginxs.unpackbits(src,dst);

        public static ulong pack_64u(ConstBlock256<byte> lo, ConstBlock256<byte> hi)
            => ginxs.bitpack(lo,hi);
        
        public static void unpack_64u(ulong src, Block256<byte> dst)
            => ginxs.unpackbits(src,dst);

        public static ulong broadcast_8x64(byte pattern)
            => ginxs.broadcast(pattern, out ulong _);

        public static ulong broadcast_8x64_const()
            => ginxs.broadcast((byte)0b11001100, out ulong _);

    }

}