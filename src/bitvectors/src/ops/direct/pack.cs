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

    partial class BitVector
    {
        [MethodImpl(Inline), Op]
        public static void pack4x4(ushort src, Span<BitVector4> dst)
        {
            ref var target = ref @as<BitVector4,byte>(memory.first(dst));
            BitPack.pack4x4(src, ref target);
        }

        [MethodImpl(Inline), Op]
        public static void pack4x8(uint src, Span<BitVector4> dst)
        {
            ref var target = ref @as<BitVector4,byte>(memory.first(dst));
            BitPack.pack4x8(src, ref target);
        }

        [MethodImpl(Inline), Op]
        public static void part8x4(uint src, Span<BitVector8> dst)
        {
            ref var target = ref @as<BitVector8,byte>(memory.first(dst));
            BitPack.pack8x4(src, ref target);
        }

        [MethodImpl(Inline), Op]
        public static void pack16x2(uint src, Span<BitVector16> dst)
        {
            ref var target = ref @as<BitVector16,ushort>(memory.first(dst));
            BitPack.pack16x2(src, ref target);
        }

        [MethodImpl(Inline), Op]
        public static void part8x8(ulong src, Span<BitVector8> dst)
        {
            ref var target = ref @as<BitVector8,byte>(memory.first(dst));
            BitPack.pack8x8(src, ref target);
        }

        [MethodImpl(Inline), Op]
        public static void pack16x2(uint src, Span<BitVector<ushort>> dst)
        {
            ref var target = ref @as<BitVector<ushort>,ushort>(memory.first(dst));
            BitPack.pack16x2(src, ref target);
        }

        [MethodImpl(Inline), Op]
        public static void pack8x8(ulong src, Span<BitVector<byte>> dst)
        {
            ref var target = ref @as<BitVector<byte>,byte>(memory.first(dst));
            BitPack.pack8x8(src, ref target);
        }
    }
}