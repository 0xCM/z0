//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    partial class SpannedBits
    {
        [MethodImpl(Inline), Op]
        public static byte extract(in BitSpan32 src, N8 count, int offset)
        {
            var v0 = vload(n256, first(extract(src, offset, count)));
            return (byte)vpacklsb(vcompact(v0, n128, z8));
        }

        [MethodImpl(Inline), Op]
        public static ushort extract(in BitSpan32 src, N16 count, int offset)
        {
            ref readonly var unpacked = ref first(extract(src, offset, count));
            return BitPack.pack(unpacked, count, w16);
        }

        [MethodImpl(Inline), Op]
        public static uint extract(in BitSpan32 src, N32 count, int offset)
        {
            ref readonly var unpacked = ref first(extract(src, offset, count));
            return BitPack.pack(unpacked, count, w32);
        }

        [MethodImpl(Inline), Op]
        public static ulong extract(in BitSpan32 src, N64 count, int offset)
        {
            ref readonly var unpacked = ref first(extract(src, offset, count));
            return BitPack.pack(unpacked, count, w64);
        }

        [MethodImpl(Inline), Op]
        public static Span<uint> extract(in BitSpan32 src, int offset, int count)
           => src.Edit.Slice(offset, count).Cast<Bit32,uint>();
    }
}