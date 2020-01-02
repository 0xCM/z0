//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static AsIn;
    using static dinx;

    partial class BitPack
    {
       /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static byte pack8(ulong src)
            => (byte)Bits.gather(src, BitMasks.Lsb64x8x1);

        /// <summary>
        /// Packs 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static ushort maskpack16<T>(in T src)
            where T : unmanaged
                => vtakemask(ginx.vsll(CpuVector.vload(n128, const64(src)),7));

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static uint maskpack32<T>(in T src)
            where T : unmanaged
                => vtakemask(ginx.vsll(CpuVector.vload(n256, const64(src)),7));

        [MethodImpl(Inline)]
        static ulong maskpack64<T>(in T src)
            where T : unmanaged
        {
            var dst = 0ul;
            dst = (ulong)maskpack32(in src);
            dst |=(ulong)maskpack32(in skip(in src, 32)) << 32;
            return dst;
        }        

        [MethodImpl(Inline)]
        static Span<uint> convert(Span<bit> src, int offset, int count)
           => src.Slice(offset, count).As<bit,uint>();

    }

}