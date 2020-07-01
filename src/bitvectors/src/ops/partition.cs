//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst; 
    using static Typed;

    partial class BitVector
    {
        [MethodImpl(Inline), Op]
        public static Span<BitVector4> partition(ushort src, Span<BitVector4> dst)
        {
            Bits.part4x4(src, ref NatSpan.bytes(dst,n4).Head);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector8> partition(ushort src, Span<BitVector8> dst)
        {
            Bits.part2x8(src, ref NatSpan.bytes(dst,n2).Head);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector4> partition(uint src, Span<BitVector4> dst)
        {
            Bits.part8x4(src, ref NatSpan.bytes(dst,n8).Head);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector8> partition(uint src, Span<BitVector8> dst)
        {
            Bits.part4x8(src, ref NatSpan.bytes(dst,n4).Head);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector16> partition(uint src, Span<BitVector16> dst)
        {
            Bits.part32x16(src, ref NatSpan.load(dst.AsUInt16(), n2).Head);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector8> partition(ulong src, Span<BitVector8> dst)
        {            
            Bits.part8x8(src, ref NatSpan.bytes(dst,n8).Head);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector<byte>> partition(ushort src, Span<BitVector<byte>> dst)
        {
            Bits.part2x8(src, ref NatSpan.bytes(dst,n2).Head);
            return dst;
        }


        [MethodImpl(Inline), Op]
        public static byte partition(uint src, ref byte dst)
        {
            Bits.part4x8(src, ref dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector<ushort>> partition(uint src, Span<BitVector<ushort>> dst)
        {
            Bits.part32x16(src, ref NatSpan.load(dst.AsUInt16(), n2).Head);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<BitVector<byte>> partition(ulong src, Span<BitVector<byte>> dst)
        {            
            Bits.part8x8(src, ref NatSpan.bytes(dst,n8).Head);
            return dst;
        }
    }
}