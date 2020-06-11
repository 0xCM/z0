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
    
    partial class gbits
    {    
        /// <summary>
        /// Extracts a contiguous range of bits from a primal source inclusively between two index positions
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="rhs">The left bit position</param>
        /// <param name="dst">The right bit position</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Extract, Closures(AllNumeric)]
        public static T extract<T>(T src, byte p0, byte p1)
            where T : unmanaged
                => extract_u(src,p0,p1);

        /// <summary>
        /// Extracts a contiguous sequence of bits from a source and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="a">The bit source</param>
        /// <param name="first">The 0-based index of the first selected bit</param>
        /// <param name="last">The 0-based index of the last selected bit</param>
        /// <param name="dst">The target that receives the sequence</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void extract<T>(T a, byte first, byte last, Span<byte> dst, int offset)
            where T : unmanaged
                => Bytes.from(gbits.extract(a,first,last)).Slice(0, BitCalcs.minbytes(last - first + 1)).CopyTo(dst,offset);

        /// <summary>
        /// Extracts a T-valued segment, cross-cell or same-cell, from the source as determined by an inclusive position range
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="firstpos">The sequence-relative position of the first bit</param>
        /// <param name="lastpos">The sequence-relative position of the last bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T extract<T>(Span<T> src, BitPos<T> firstpos, BitPos<T> lastpos)
            where T : unmanaged
        {
            var bitcount = lastpos - firstpos;
            if(bitcount > bitsize<T>())
                return NumericLiterals.maxval<T>();

            var sameSeg = firstpos.CellIndex == lastpos.CellIndex;
            var firstCount = uint8(sameSeg ? bitcount : bitsize<T>() - firstpos.BitOffset);
            var part1 = gbits.slice(bitcell(src,firstpos), (byte)firstpos.BitOffset, firstCount);
            
            if(sameSeg)
                return part1;
            else
            {
                var lastCount = uint8(bitcount - firstCount);
                return gmath.or(part1, gmath.sal(gbits.slice(bitcell(src,lastpos), 0, lastCount), firstCount));              
            }
        }

        /// <summary>
        /// Extracts a T-valued segment, cross-cell or same-cell, from the source as determined by 
        /// an inclusive linear index range
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="firstidx">The sequence-relative index of the first bit</param>
        /// <param name="lastidx">The sequence-relative index of the last bit</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T extract<T>(Span<T> src, int firstidx, int lastidx)
            where T : unmanaged
                => extract(src, bitpos<T>(firstidx), bitpos<T>(lastidx));         

        [MethodImpl(Inline)]
        static T extract_i<T>(T src, byte p0, byte p1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(Bits.extract(int8(src), p0, p1));
            else if(typeof(T) == typeof(short))
                 return generic<T>(Bits.extract(int16(src), p0, p1));
            else if(typeof(T) == typeof(int))
                 return generic<T>(Bits.extract(int32(src), p0, p1));
            else if(typeof(T) == typeof(long))
                 return generic<T>(Bits.extract(int64(src), p0, p1));
            else
                return extract_f(src,p0,p1);
        }

        [MethodImpl(Inline)]
        static T extract_u<T>(T src, byte p0, byte p1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(Bits.extract(uint8(src), p0, p1));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(Bits.extract(uint16(src), p0, p1));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(Bits.extract(uint32(src), p0, p1));
            else if(typeof(T) == typeof(ulong))
                 return generic<T>(Bits.extract(uint64(src), p0, p1));
            else 
                return extract_i(src,p0,p1);
        }

        [MethodImpl(Inline)]
        static T extract_f<T>(T src, byte p0, byte p1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(Bits.extract(float32(src), p0, p1));
            else if(typeof(T) == typeof(double))
                 return generic<T>(Bits.extract(float64(src),  p0, p1));
            else            
                throw Unsupported.define<T>();
        }
    }
}