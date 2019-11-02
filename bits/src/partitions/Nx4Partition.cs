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
        const uint M4 = 0b1111;

        /// <summary>
        /// Partitions an 8-bit source value into 2 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part8x4(uint src, Span<byte> dst)
        {
            seek(ref head(dst), 0) = (byte)((src >> 0) & M4);
            seek(ref head(dst), 1) = (byte)((src >> 4) & M4);
        }

        /// <summary>
        /// Partitions the first 12 bits of a 32-bit source value into 3 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part12x4(uint src, Span<byte> dst)
        {
            seek(ref head(dst), 0) = (byte)((src >> 0) & M4);
            seek(ref head(dst), 1) = (byte)((src >> 4) & M4);
            seek(ref head(dst), 2) = (byte)((src >> 8) & M4);
        }

        /// <summary>
        /// Partitions a 32-bit source value into 4 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part16x4(uint src, ref byte dst)
        {
            seek(ref dst, 0) = (byte)((src >> 0) & M4);
            seek(ref dst, 1) = (byte)((src >> 4) & M4);
            seek(ref dst, 2) = (byte)((src >> 8) & M4);
            seek(ref dst, 3) = (byte)((src >> 12) & M4);
        }

        [MethodImpl(Inline)]
        public static void part32x4(uint src, ref byte dst)
        {
            part16x4(src, ref dst);
            part16x4(src >> 16, ref seek(ref dst, 4));
        }

        /// <summary>
        /// Partitions a 16-bit source value into 4 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part16x4(uint src, Span<byte> dst)
            => part16x4(src, ref head(dst));

        /// <summary>
        /// Partitions a 32-bit source value into 8 segments with an effective bit width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part32x4(uint src, Span<byte> dst)
            => part32x4(src, ref head(dst));

    }
}