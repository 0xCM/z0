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
        public static Span<uint> extract32(in BitSpan32 src, int offset, int count)
           => src.Edit.Slice(offset, count).Recover<Bit32,uint>();

        [MethodImpl(Inline), Op]
        public static byte extract32(in BitSpan32 src, N8 count, int offset)
        {
            var v0 = cpu.vload(w256, first(extract32(src, offset, count)));
            return (byte)gcpu.vpacklsb(cpu.vpack128x8u(v0, w128));
        }

        [MethodImpl(Inline), Op]
        public static ushort extract32(in BitSpan32 src, N16 count, int offset)
        {
            ref readonly var unpacked = ref first(extract32(src, offset, count));
            var buffer = z16;
            return BitPack.pack16x32x1(unpacked, ref buffer);
        }

        [MethodImpl(Inline), Op]
        public static uint extract32(in BitSpan32 src, N32 count, int offset)
        {
            ref readonly var unpacked = ref first(extract32(src, offset, count));
            var buffer = z32;
            return BitPack.pack32x32x1(unpacked, ref buffer);
        }

        [MethodImpl(Inline), Op]
        public static ulong extract32(in BitSpan32 src, N64 count, int offset)
        {
            ref readonly var unpacked = ref first(extract32(src, offset, count));
            var buffer = z64;
            return BitPack.pack64x32x1(unpacked, ref buffer);
        }
    }
}