//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static Bits;

    partial class BitParts
    {        
        [MethodImpl(Inline)]
        public static ref ushort pack16x1(Span<byte> src, ref ushort dst)
        {            
            const int width = 8;
            const ulong selected = (ulong)BitMask64.Lsb8;

            dst |= (ushort)Bits.gather(block64u(src, 0*width), selected);
            dst |= (ushort)(Bits.gather(block64u(src, 1*width), selected) << 1*width);
            return ref dst;
        }

        public static ref uint pack32x1(Span<byte> src, ref uint dst)
        {            
            const int width = 8;
            const ulong selected = (ulong)BitMask64.Lsb8;
            dst |= (uint)Bits.gather(block64u(src, 0*width), selected);
            dst |= (uint)(Bits.gather(block64u(src, 1*width), selected) << 1*width);
            dst |= (uint)(Bits.gather(block64u(src, 2*width), selected) << 2*width);
            dst |= (uint)(Bits.gather(block64u(src, 3*width), selected) << 3*width);
            return ref dst;
        }

        public static ref ulong pack64x1(Span<byte> src, ref ulong dst)
        {
            const int width = 8;
            const ulong selected = (ulong)BitMask64.Lsb8;
            dst |= Bits.gather(block64u(src, 0*width), selected);
            dst |= (Bits.gather(block64u(src, 1*width), selected) << 1*width);
            dst |= (Bits.gather(block64u(src, 2*width), selected) << 2*width);
            dst |= (Bits.gather(block64u(src, 3*width), selected) << 3*width);
            dst |= (Bits.gather(block64u(src, 4*width), selected) << 4*width);
            dst |= (Bits.gather(block64u(src, 5*width), selected) << 5*width);
            dst |= (Bits.gather(block64u(src, 6*width), selected) << 6*width);
            dst |= (Bits.gather(block64u(src, 7*width), selected) << 7*width);
            return ref dst;
        }

        /// <summary>
        /// Unpacks 8 bits from a byte 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <remarks>This operation is non-allocating</remarks>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> unpack8x1(byte src)
            => BitStore.select(src);

        /// <summary>
        /// Unpacks 8 bits from a byte to caller-supplied bytespan
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static void unpack8x1(byte src, Span<byte> dst)
            => BitConverter.GetBytes(Bits.scatter((uint)src, (ulong)BitMask64.Lsb8)).CopyTo(dst);

        /// <summary>
        /// Unpacks 16 bits from a 16-bit unsigned integer to a caller-supplied 
        /// bytespan of length ath least 16
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static Span<byte> unpack16x1(ushort src, Span<byte> dst)
        {
            (var lo, var hi) = Bits.split(src);
            unpack8x1(lo, dst);
            unpack8x1(hi, dst.Slice(8));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> unpack16x1(ushort src)
            => unpack16x1(src, new byte[16]);
        

        public static void unpack32x1(uint src, Span<byte> dst)
        {
            var bytes = BitConverter.GetBytes(src);
            BitStore.select(bytes[0]).CopyTo(dst,0);
            BitStore.select(bytes[1]).CopyTo(dst,8);
            BitStore.select(bytes[2]).CopyTo(dst,16);
            BitStore.select(bytes[3]).CopyTo(dst,24);
        }

        public static Span<byte> unpack32x1_bmi(uint src, Span<byte> dst)
        {
            (var lo, var hi) = Bits.split(src);
            unpack16x1(lo, dst);
            unpack16x1(hi, dst.Slice(16));
            return dst;
        }

        public static Span<byte> unpack64x1(ulong src, Span<byte> dst)
        {
            (var lo, var hi) = Bits.split(src);
            unpack32x1_bmi(lo, dst);
            unpack32x1_bmi(hi, dst.Slice(32));
            return dst;
        }        

        public static Span<byte> unpack8x1(ReadOnlySpan<byte> src, Span<byte> dst)
        {            
            var offset = 0;
            for(var i = 0; i<src.Length; i++, offset += 8)
                unpack8x1(src[i]).CopyTo(dst.Slice(offset));
            return dst;
        }

        [MethodImpl(Inline)]        
        public static Span<byte> unpack16x1(ReadOnlySpan<ushort> src, Span<byte> dst)
            => unpack8x1(src.AsBytes(),dst);

        [MethodImpl(Inline)]        
        public static Span<byte> unpack32x1(ReadOnlySpan<uint> src, Span<byte> dst)
            => unpack8x1(src.AsBytes(),dst);

        [MethodImpl(Inline)]        
        public static Span<byte> unpack64x1(ReadOnlySpan<ulong> src, Span<byte> dst)
            => unpack8x1(src.AsBytes(),dst);

    }
}