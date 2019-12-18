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

        public static byte pack_8(ConstBlock64<byte> src)
            => ginxs.bitpack(src);

        public static ushort pack_16(ConstBlock128<byte> src)
            => ginxs.bitpack(src);

        public static uint pack_32(ConstBlock256<byte> src)
            => ginxs.bitpack(src);

        public static ulong pack_64(ConstBlock512<byte> src)
            => ginxs.bitpack(src);

        public static void unpack_8(byte src, Block64<byte> dst)
            => ginxs.unpackbits(src,dst);

        public static void unpack_16(ushort src, Block128<byte> dst)
            => ginxs.unpackbits(src,dst);

        public static void unpack_32(uint src, Block256<byte> dst)
            => ginxs.unpackbits(src,dst);
        
        public static void unpack_64(ulong src, Block512<byte> dst)
            => ginxs.unpackbits(src,dst);

        public static ulong broadcast_8x64(byte pattern)
            => ginxs.broadcast(pattern, out ulong _);

        public static ulong broadcast_8x64_const()
            => ginxs.broadcast((byte)0b11001100, out ulong _);

    }

}