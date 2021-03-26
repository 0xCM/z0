//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static cpu;

    [ApiHost]
    public readonly struct BitSpan32Scalars
    {
        [MethodImpl(Inline), Op]
        public static BitSpan32 from(byte src)
        {
            var buffer = MemBlocks.alloc(n8);
            ref var tmp = ref MemBlocks.first<byte>(ref buffer);

            var storage = MemBlocks.alloc(n32);
            ref var target = ref MemBlocks.first<uint>(ref storage);

            BitPack.unpack1x8x8(src, ref tmp);
            vinflate8x256x32u(tmp, 0, ref target);
            return BitSpans32.load(MemBlocks.span<uint>(ref storage).Recover<Bit32>());
        }

        [MethodImpl(Inline), Op]
        public static BitSpan32 from(ushort src)
        {
            var buffer = MemBlocks.alloc(n16);
            ref var tmp = ref MemBlocks.first<byte>(ref buffer);

            var storage = MemBlocks.alloc(n64);
            ref var target = ref MemBlocks.first<uint>(ref storage);

            BitPack.unpack1x8x16(src, ref tmp);
            vinflate8x256x32u(tmp, 0, ref target);
            vinflate8x256x32u(tmp, 1, ref target);
            return BitSpans32.load(MemBlocks.span<uint>(ref storage).Recover<Bit32>());
        }

        [MethodImpl(Inline), Op]
        public static BitSpan32 from(uint src)
        {
            var buffer = MemBlocks.alloc(n32);
            ref var tmp = ref MemBlocks.first<byte>(ref buffer);

            var storage = MemBlocks.alloc(n128);
            ref var target = ref MemBlocks.first<uint>(ref storage);

            BitPack.unpack1x8x32(src, ref tmp);
            vinflate8x256x32u(tmp, 0, ref target);
            vinflate8x256x32u(tmp, 1, ref target);
            vinflate8x256x32u(tmp, 2, ref target);
            vinflate8x256x32u(tmp, 3, ref target);
            return BitSpans32.load(MemBlocks.span<uint>(ref storage).Recover<Bit32>());
        }

        [MethodImpl(Inline), Op]
        public static BitSpan32 from(ulong src)
        {
            var buffer = MemBlocks.alloc(n64);
            ref var tmp = ref MemBlocks.first<byte>(ref buffer);

            Span<uint> storage = new uint[64];
            ref var target = ref first(storage);

            BitPack.unpack1x8x64(src, ref tmp);
            vinflate8x256x32u(tmp, 0, ref target);
            vinflate8x256x32u(tmp, 1, ref target);
            vinflate8x256x32u(tmp, 2, ref target);
            vinflate8x256x32u(tmp, 3, ref target);
            vinflate8x256x32u(tmp, 4, ref target);
            vinflate8x256x32u(tmp, 5, ref target);
            vinflate8x256x32u(tmp, 6, ref target);
            vinflate8x256x32u(tmp, 7, ref target);
            return BitSpans32.load(storage.Recover<Bit32>());
        }

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan32 fill(byte src, in BitSpan32 dst)
        {
            var buffer = MemBlocks.alloc(n8);
            ref var tmp = ref MemBlocks.first<byte>(ref buffer);
            ref var target = ref Unsafe.As<Bit32,uint>(ref first(dst.Edit));

            BitPack.unpack1x8x8(src, ref tmp);
            vinflate8x256x32u(tmp, 0, ref target);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan32 fill(ushort src, in BitSpan32 dst)
        {
            var buffer = MemBlocks.alloc(n16);
            ref var tmp = ref MemBlocks.first<byte>(ref buffer);
            ref var target = ref Unsafe.As<Bit32,uint>(ref first(dst.Edit));

            BitPack.unpack1x8x16(src, ref tmp);
            vinflate8x256x32u(tmp, 0, ref target);
            vinflate8x256x32u(tmp, 1, ref target);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan32 fill(uint src, in BitSpan32 dst)
        {
            ref var tmp = ref first(dst.Edit.Slice(24,8).Recover<Bit32,byte>());
            ref var target = ref Unsafe.As<Bit32,uint>(ref first(dst.Edit));

            BitPack.unpack1x8x32(src, ref tmp);
            vinflate8x256x32u(tmp, 0, ref target);
            vinflate8x256x32u(tmp, 1, ref target);
            vinflate8x256x32u(tmp, 2, ref target);
            vinflate8x256x32u(tmp, 3, ref target);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan32 fill(ulong src, in BitSpan32 dst)
        {
            var buffer = MemBlocks.alloc(n64);
            ref var tmp = ref first(dst.Edit.Slice(56,8).Recover<Bit32,byte>());
            ref var target = ref Unsafe.As<Bit32,uint>(ref first(dst.Edit));

            BitPack.unpack1x8x32((uint)src, ref tmp);
            vinflate8x256x32u(tmp, 0, ref target, 0);
            vinflate8x256x32u(tmp, 1, ref target, 1);
            vinflate8x256x32u(tmp, 2, ref target, 2);
            vinflate8x256x32u(tmp, 3, ref target, 3);

            BitPack.unpack1x8x32((uint)(src >> 32), ref tmp);
            vinflate8x256x32u(tmp, 0, ref target, 4);
            vinflate8x256x32u(tmp, 1, ref target, 5);
            vinflate8x256x32u(tmp, 2, ref target, 6);
            vinflate8x256x32u(tmp, 3, ref target, 7);
            return ref dst;
        }


        [MethodImpl(Inline), Op]
        public static Span<uint> extract(in BitSpan32 src, int offset, int count)
           => slice(src.Edit,offset, count).Recover<Bit32,uint>();

        [MethodImpl(Inline), Op]
        public static byte extract8(in BitSpan32 src, int offset)
        {
            ref readonly var unpacked = ref first(extract(src, offset, 8));
            return (byte)gcpu.vpacklsb(vpack128x8u(vload(w256, unpacked)));
        }

        [MethodImpl(Inline), Op]
        public static ushort extract16(in BitSpan32 src, int offset)
        {
            ref readonly var unpacked = ref first(extract(src, offset, 16));
            var buffer = z16;
            return BitPack.pack16x32x1(unpacked, ref buffer);
        }

        [MethodImpl(Inline), Op]
        public static uint extract32(in BitSpan32 src, int offset)
        {
            ref readonly var unpacked = ref first(extract(src, offset, 32));
            var buffer = z32;
            return BitPack.pack32x32x1(unpacked, ref buffer);
        }

        [MethodImpl(Inline), Op]
        public static ulong extract64(in BitSpan32 src, int offset)
        {
            ref readonly var unpacked = ref first(extract(src, offset, 64));
            var buffer = z64;
            return BitPack.pack64x32x1(unpacked, ref buffer);
        }
    }
}