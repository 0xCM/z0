//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class SpannedBits
    {
        [MethodImpl(Inline), Op]
        public static byte extract(in BitSpan src, N8 n, int offset)
        {
            var v0 = Vectors.vload(n256, head(extract(src, offset, bitsize<byte>())));
            return (byte)BitPack.packlsb8(dvec.vcompact(v0,n128,z8));
        }

        [MethodImpl(Inline), Op]
        public static ushort extract(in BitSpan src, N16 n, int offset)
        {
            ref readonly var unpacked = ref head(extract(src, offset, bitsize<ushort>())); 
            return BitPack.pack32(unpacked, n);
        }

        [MethodImpl(Inline), Op]
        public static uint extract(in BitSpan src, N32 n, int offset)
        {
            ref readonly var unpacked = ref head(extract(src, offset, bitsize<uint>()));            
            return BitPack.pack32(unpacked,n);            
        }

        [MethodImpl(Inline), Op]
        public static ulong extract(in BitSpan src, N64 n, int offset)
        {
            ref readonly var unpacked = ref head(extract(src, offset, bitsize<ulong>()));
            return BitPack.pack32(unpacked,n);
        }

        [MethodImpl(Inline), Op]
        public static Span<uint> extract(in BitSpan src, int offset, int count)
           => src.Bits.Slice(offset, count).As<bit,uint>();        
    }
}