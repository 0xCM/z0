//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; using static Memories;

    partial class BitVector
    {
        [MethodImpl(Inline), Op]
        public static Span<BitVector4> partition(BitVector16 src, Span<BitVector4> dst)
        {
            Bits.part4x4(src, NatSpan.bytes(dst,n4));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector8> partition(BitVector16 src, Span<BitVector8> dst)
        {
            Bits.part2x8(src, NatSpan.bytes(dst,n2));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector4> partition(BitVector32 src, Span<BitVector4> dst)
        {
            Bits.part8x4(src, NatSpan.bytes(dst,n8));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector8> partition(BitVector32 src, Span<BitVector8> dst)
        {
            Bits.part4x8(src, NatSpan.bytes(dst,n4));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector16> partition(BitVector32 src, Span<BitVector16> dst)
        {
            Bits.part32x16(src, NatSpan.load(dst.AsUInt16(), n2));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector8> partition(BitVector64 src, Span<BitVector8> dst)
        {            
            Bits.part8x8(src, NatSpan.bytes(dst,n8));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector<byte>> partition(BitVector<ushort> src, Span<BitVector<byte>> dst)
        {
            Bits.part2x8(src, NatSpan.bytes(dst,n2));
            return dst;
        }


        [MethodImpl(Inline), Op]
        public static Span<BitVector<byte>> partition(BitVector<uint> src, Span<BitVector<byte>> dst)
        {
            Bits.part4x8(src, NatSpan.bytes(dst,n4));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector<ushort>> partition(BitVector<uint> src, Span<BitVector<ushort>> dst)
        {
            Bits.part32x16(src, NatSpan.load(dst.AsUInt16(), n2));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector<byte>> partition(BitVector<ulong> src, Span<BitVector<byte>> dst)
        {            
            Bits.part8x8(src, NatSpan.bytes(dst,n8));
            return dst;
        }
    }
}