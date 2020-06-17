//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Memories;

    partial class SpannedBits
    {
        [MethodImpl(Inline), Op]
        public static byte extract(in BitSpan src, N8 count, int offset)
        {
            var v0 = Vectors.vload(n256, head(extract(src, offset, count)));
            return (byte)BitPack.packlsb(dvec.vcompact(v0,n128,z8), n8);
        }

        [MethodImpl(Inline), Op]
        public static ushort extract(in BitSpan src, N16 count, int offset)
        {
            ref readonly var unpacked = ref head(extract(src, offset, count)); 
            return BitPack.pack(unpacked, count, w16);
        }

        [MethodImpl(Inline), Op]
        public static uint extract(in BitSpan src, N32 count, int offset)
        {
            ref readonly var unpacked = ref head(extract(src, offset, count));            
            return BitPack.pack(unpacked,count,w32);            
        }

        [MethodImpl(Inline), Op]
        public static ulong extract(in BitSpan src, N64 count, int offset)
        {
            ref readonly var unpacked = ref head(extract(src, offset, count));
            return BitPack.pack(unpacked, count, w64);
        }

        [MethodImpl(Inline), Op]
        public static Span<uint> extract(in BitSpan src, int offset, int count)
           => src.Bits.Slice(offset, count).As<bit,uint>();        
    }
}