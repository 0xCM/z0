//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;    
    
    public static class bitpack
    {                


        public static byte pack_8(BitSpan src)
            => BitPack.pack<byte>(src);

        public static ushort pack_16(BitSpan src)
            => BitPack.pack<ushort>(src);

        public static uint pack_32(BitSpan src)
            => BitPack.pack<uint>(src);

        public static ulong pack_64(BitSpan src)
            => BitPack.pack<ulong>(src);

        public static void unpack_64x32(ulong src, in Block64<byte> buffer, Span<uint> dst)
            => BitPack.unpack64x32(src,buffer,dst);

        public static void unpack_64x32_aloc(ulong src, Span<uint> dst)
            => BitPack.unpack64x32(src,dst);

    }

}