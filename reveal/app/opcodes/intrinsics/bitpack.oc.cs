//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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

        public static byte pack_8x8(Span<uint> src)
            => BitPack.pack8(src,0,z8);

        public static ushort pack_16x8(Span<uint> src)
            => BitPack.pack8(src,0,z16);

        public static uint pack_32x8(Span<uint> src)
            => BitPack.pack8(src,0,z32);

        public static ulong pack_64x8(Span<uint> src)
            => BitPack.pack8(src,0,z64);

        public static void unpack_64x32(ulong src, Span<uint> dst)
            => BitPack.unpack32(src,dst);



    }

}