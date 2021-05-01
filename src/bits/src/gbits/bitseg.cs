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

    partial class gbits
    {
        /// <summary>
        /// Extracts a contiguous range of bits from a primal source inclusively between two index positions
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="rhs">The left bit position</param>
        /// <param name="dst">The right bit position</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), BitSeg, Closures(AllNumeric)]
        public static T bitseg<T>(T src, byte p0, byte p1)
            where T : unmanaged
                => bitseg_u(src, p0, p1);

        /// <summary>
        /// Extracts a contiguous sequence of bits from a source and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="a">The bit source</param>
        /// <param name="i0">The 0-based index of the first selected bit</param>
        /// <param name="i1">The 0-based index of the last selected bit</param>
        /// <param name="dst">The target that receives the sequence</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline), BitSeg, Closures(Closure)]
        public static void bitseg<T>(T a, byte i0, byte i1, Span<byte> dst, int offset)
            where T : unmanaged
        {
            var seg = bitseg(a, i0, i1);
            var kBytes = bit.minbytes(i1 - i0 + 1);
            var src = slice(bytes<T>(seg), 0, kBytes);
            copy(src,offset,dst);
        }

        [MethodImpl(Inline)]
        static void copy(Span<byte> src, int offset, Span<byte> dst)
        {
            var count = src.Length;
            var j=0;
            for(var i=offset; i<offset + count; i++)
                seek(dst,j++) = skip(src,i);
        }

        /// <summary>
        /// Extracts a T-valued segment, cross-cell or same-cell, from the source as determined by an inclusive position range
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The sequence-relative position of the first bit</param>
        /// <param name="i1">The sequence-relative position of the last bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), BitSeg, Closures(Closure)]
        public static T bitseg<T>(Span<T> src, BitPos<T> i0, BitPos<T> i1)
            where T : unmanaged
        {
            var bitcount = (uint)(i1 - i0);
            if(bitcount > width<T>())
                return Numeric.maxval<T>();

            var sameSeg = i0.CellIndex == i1.CellIndex;
            var firstCount = ScalarCast.uint8(sameSeg ? bitcount : (uint)(width<T>() - i0.BitOffset));
            var part1 = bitslice(bitcell(src, i0), (byte)i0.BitOffset, firstCount);

            if(sameSeg)
                return part1;
            else
            {
                var lastCount = ScalarCast.uint8(bitcount - firstCount);
                return gmath.or(part1, gmath.sal(bitslice(bitcell(src,i1), 0, lastCount), firstCount));
            }
        }

        /// <summary>
        /// Extracts a T-valued segment, cross-cell or same-cell, from the source as determined by
        /// an inclusive linear index range
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The sequence-relative index of the first bit</param>
        /// <param name="i1">The sequence-relative index of the last bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), BitSeg, Closures(Closure)]
        public static T bitseg<T>(Span<T> src, int i0, int i1)
            where T : unmanaged
                => bitseg(src, bitpos<T>(i0), bitpos<T>(i1));

        [MethodImpl(Inline)]
        static T bitseg_i<T>(T src, byte i0, byte i1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(Bits.bitseg(int8(src), i0, i1));
            else if(typeof(T) == typeof(short))
                 return generic<T>(Bits.bitseg(int16(src), i0, i1));
            else if(typeof(T) == typeof(int))
                 return generic<T>(Bits.bitseg(int32(src), i0, i1));
            else if(typeof(T) == typeof(long))
                 return generic<T>(Bits.bitseg(int64(src), i0, i1));
            else
                return bitseg_f(src,i0,i1);
        }

        [MethodImpl(Inline)]
        static T bitseg_u<T>(T src, byte i0, byte i1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(Bits.bitseg(uint8(src), i0, i1));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(Bits.bitseg(uint16(src), i0, i1));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(Bits.bitseg(uint32(src), i0, i1));
            else if(typeof(T) == typeof(ulong))
                 return generic<T>(Bits.bitseg(uint64(src), i0, i1));
            else
                return bitseg_i(src,i0,i1);
        }

        [MethodImpl(Inline)]
        static T bitseg_f<T>(T src, byte i0, byte i1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(Bits.bitseg(float32(src), i0, i1));
            else if(typeof(T) == typeof(double))
                 return generic<T>(Bits.bitseg(float64(src),  i0, i1));
            else
                throw no<T>();
        }
    }
}