//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static Bits;

    partial class BitParts
    {        
        /// <summary>
        /// Partitions the first 6 bits of a source into 6 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part6x1(byte src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part6x1.Part0), Part6x1.First);
            dst[1] = project<byte>(select(src, Part6x1.Part1), Part6x1.First);
            dst[2] = project<byte>(select(src, Part6x1.Part2), Part6x1.First);
            dst[3] = project<byte>(select(src, Part6x1.Part3), Part6x1.First);
            dst[4] = project<byte>(select(src, Part6x1.Part4), Part6x1.First);
            dst[5] = project<byte>(select(src, Part6x1.Part5), Part6x1.First);
        }


        /// <summary>
        /// Partitions the first 7 bits of source into 7 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part7x1(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part7x1.Part0), Part7x1.First);
            dst[1] = project<byte>(select(src, Part7x1.Part1), Part7x1.First);
            dst[2] = project<byte>(select(src, Part7x1.Part2), Part7x1.First);
            dst[3] = project<byte>(select(src, Part7x1.Part3), Part7x1.First);
            dst[4] = project<byte>(select(src, Part7x1.Part4), Part7x1.First);
            dst[5] = project<byte>(select(src, Part7x1.Part5), Part7x1.First);
            dst[6] = project<byte>(select(src, Part7x1.Part6), Part7x1.First);
        }

        /// <summary>
        /// Partitions 8 bits of a source into 8 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part8x1(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part8x1.Part0), Part8x1.First);
            dst[1] = project<byte>(select(src, Part8x1.Part1), Part8x1.First);
            dst[2] = project<byte>(select(src, Part8x1.Part2), Part8x1.First);
            dst[3] = project<byte>(select(src, Part8x1.Part3), Part8x1.First);
            dst[4] = project<byte>(select(src, Part8x1.Part4), Part8x1.First);
            dst[5] = project<byte>(select(src, Part8x1.Part5), Part8x1.First);
            dst[6] = project<byte>(select(src, Part8x1.Part6), Part8x1.First);
            dst[7] = project<byte>(select(src, Part8x1.Part7), Part8x1.First);
        }

        /// <summary>
        /// Partitions the first 9 bits of a 16-bit source into 9 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part9x1(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part9x1.Part0), Part9x1.First);
            dst[1] = project<byte>(select(src, Part9x1.Part1), Part9x1.First);
            dst[2] = project<byte>(select(src, Part9x1.Part2), Part9x1.First);
            dst[3] = project<byte>(select(src, Part9x1.Part3), Part9x1.First);
            dst[4] = project<byte>(select(src, Part9x1.Part4), Part9x1.First);
            dst[5] = project<byte>(select(src, Part9x1.Part5), Part9x1.First);
            dst[6] = project<byte>(select(src, Part9x1.Part6), Part9x1.First);
            dst[7] = project<byte>(select(src, Part9x1.Part7), Part9x1.First);
            dst[8] = project<byte>(select(src, Part9x1.Part8), Part9x1.First);
        }


        /// <summary>
        /// Partitions the first 10 bits of a 16-bit source into 9 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part10x1(ushort src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part10x1.Part0), Part10x1.First);
            dst[1] = project<byte>(select(src, Part10x1.Part1), Part10x1.First);
            dst[2] = project<byte>(select(src, Part10x1.Part2), Part10x1.First);
            dst[3] = project<byte>(select(src, Part10x1.Part3), Part10x1.First);
            dst[4] = project<byte>(select(src, Part10x1.Part4), Part10x1.First);
            dst[5] = project<byte>(select(src, Part10x1.Part5), Part10x1.First);
            dst[6] = project<byte>(select(src, Part10x1.Part6), Part10x1.First);
            dst[7] = project<byte>(select(src, Part10x1.Part7), Part10x1.First);
            dst[8] = project<byte>(select(src, Part10x1.Part8), Part10x1.First);
            dst[9] = project<byte>(select(src, Part10x1.Part9), Part10x1.First);

        }



        [MethodImpl(Inline)]
        public static ref ulong project8x64(byte src, ref ulong dst)
        {
            dst = Bits.scatter((ulong)src, (ulong)BitMasks.Lsb64x8.Select);            
            return ref dst;
        }

        /// <summary>
        /// Partitions 32 bits from the source into 32 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part32x1(uint src, Span<byte> dst)
        {                    
            project8x64(select(src, Part32x8.Part0), ref dst.Slice(0,8).AsUInt64()[0]);
            project8x64(select(src, Part32x8.Part1), ref dst.Slice(8,8).AsUInt64()[0]);
            project8x64(select(src, Part32x8.Part2), ref dst.Slice(16,8).AsUInt64()[0]);
            project8x64(select(src, Part32x8.Part3), ref dst.Slice(24,8).AsUInt64()[0]);

        }

        /// <summary>
        /// Partitions 32 bits from the source into 32 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part64x1(ulong src, Span<byte> dst)
        {                    
            const int step = 8;
            const ulong selected = (ulong)BitMasks.Lsb64x8.Select;

            block64u(dst, 0*step) = Bits.scatter(select(src, Part64x8.Part0), selected);
            block64u(dst, 1*step) = Bits.scatter(select(src, Part64x8.Part1), selected);
            block64u(dst, 2*step) = Bits.scatter(select(src, Part64x8.Part2), selected);
            block64u(dst, 3*step) = Bits.scatter(select(src, Part64x8.Part3), selected);
            block64u(dst, 4*step) = Bits.scatter(select(src, Part64x8.Part4), selected);
            block64u(dst, 5*step) = Bits.scatter(select(src, Part64x8.Part5), selected);
            block64u(dst, 6*step) = Bits.scatter(select(src, Part64x8.Part6), selected);
            block64u(dst, 7*step) = Bits.scatter(select(src, Part64x8.Part7), selected);
        }

    }


}