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
        const uint M2 = 0b11;

        /// <summary>
        /// Partitions the first 8 bits of a 32-bit source into 4 target segments each with an effective width of 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part8x2(uint src, ref byte dst)
        {
            seek(ref dst, 0) = (byte)(src >> 0 & M2);
            seek(ref dst, 1) = (byte)(src >> 2 & M2);
            seek(ref dst, 2) = (byte)(src >> 4 & M2);
            seek(ref dst, 3) = (byte)(src >> 6 & M2);
        }

        /// <summary>
        /// Partitions the first 16 bits of a 32-bit source into 8 target segments each with an effective width of 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part16x2(uint src, ref byte dst)
        {
            part8x2(src, ref dst);
            part8x2(src >> 8, ref seek(ref dst, 4));
        }

        /// <summary>
        /// Partitions a 32-bit source into 16 target segments each with an effective width of 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part32x2(uint src, ref byte dst)
        {
            part16x2(src, ref dst);
            part16x2(src >> 16, ref seek(ref dst, 8));
        }
    }
}