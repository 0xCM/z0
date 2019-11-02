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
        const uint M1 = 1;

        /// <summary>
        /// Partitions the first 6 bits of a 32-bit source into 6 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part6x1(uint src, ref byte dst)
        {
            seek(ref dst, 0) = (byte)(src >> 0 & M1);
            seek(ref dst, 1) = (byte)(src >> 1 & M1);
            seek(ref dst, 2) = (byte)(src >> 2 & M1);
            seek(ref dst, 3) = (byte)(src >> 3 & M1);
            seek(ref dst, 4) = (byte)(src >> 4 & M1);
            seek(ref dst, 5) = (byte)(src >> 5 & M1);
        }

        /// <summary>
        /// Partitions the first 7 bits of a 32-bit source into 7 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part7x1(uint src, ref byte dst)
        {
            seek(ref dst, 0) = (byte)(src >> 0 & M1);
            seek(ref dst, 1) = (byte)(src >> 1 & M1);
            seek(ref dst, 2) = (byte)(src >> 2 & M1);
            seek(ref dst, 3) = (byte)(src >> 3 & M1);
            seek(ref dst, 4) = (byte)(src >> 4 & M1);
            seek(ref dst, 5) = (byte)(src >> 5 & M1);
            seek(ref dst, 6) = (byte)(src >> 6 & M1);
        }

        /// <summary>
        /// Partitions 8 bits of a source into 8 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part8x1(uint src, ref byte dst)
        {
            seek(ref dst, 0) = (byte)(src >> 0 & M1);
            seek(ref dst, 1) = (byte)(src >> 1 & M1);
            seek(ref dst, 2) = (byte)(src >> 2 & M1);
            seek(ref dst, 3) = (byte)(src >> 3 & M1);
            seek(ref dst, 4) = (byte)(src >> 4 & M1);
            seek(ref dst, 5) = (byte)(src >> 5 & M1);
            seek(ref dst, 6) = (byte)(src >> 6 & M1);
            seek(ref dst, 7) = (byte)(src >> 7 & M1);
        }

        /// <summary>
        /// Partitions the first 9 bits of a 16-bit source into 9 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part9x1(uint src, ref byte dst)
        {
            part8x1(src, ref dst);
            seek(ref dst, 8) = (byte)(src >> 8 & M1);
        }

        /// <summary>
        /// Partitions the first 10 bits of a 32-bit source into 10 target segments each of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part10x1(uint src, ref byte dst)
        {
            part9x1(src, ref dst);
            seek(ref dst, 9) = (byte)(src >> 9 & M1);
        }

        /// <summary>
        /// Partitions 32 bits from the source into 32 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part32x1(uint src, Span<byte> dst)
            => part32x1(src, ref head(dst.AsUInt64()));

        /// <summary>
        /// Partitions 64 bits from a 64-bit source into 64 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part64x1(ulong src, Span<byte> dst)
            => part64x1(src, ref head64(dst));
 
         /// <summary>
        /// Partitions 32 bits from the source into 32 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        static void part32x1(uint src, ref ulong dst)
        {                    
            const ulong M = (ulong)BitMasks.Lsb64x8.Select;
            seek(ref dst, 0) = project(select(src, Part32x8.Part0), M);
            seek(ref dst, 1) = project(select(src, Part32x8.Part1), M);
            seek(ref dst, 2) = project(select(src, Part32x8.Part2), M);
            seek(ref dst, 3) = project(select(src, Part32x8.Part3), M);            
        }

        /// <summary>
        /// Partitions 64 bits from a 64-bit source value into 64 target segments of physical width 8 and effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        static void part64x1(ulong src, ref ulong dst)            
        {
            const ulong M = (ulong)BitMasks.Lsb64x8.Select;
            seek(ref dst, 0) = project(select(src, Part64x8.Part0), M);
            seek(ref dst, 1) = project(select(src, Part64x8.Part1), M);
            seek(ref dst, 2) = project(select(src, Part64x8.Part2), M);
            seek(ref dst, 3) = project(select(src, Part64x8.Part3), M);
            seek(ref dst, 4) = project(select(src, Part64x8.Part4), M);
            seek(ref dst, 5) = project(select(src, Part64x8.Part5), M);
            seek(ref dst, 6) = project(select(src, Part64x8.Part6), M);
            seek(ref dst, 7) = project(select(src, Part64x8.Part7), M);
        }


    }
}