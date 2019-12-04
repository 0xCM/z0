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
    
    partial class Bits
    {                
        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static sbyte between(sbyte src, int i0, int i1)        
            => BitMask.between(src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static byte between(byte src, int i0, int i1)        
            => BitMask.between(src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static short between(short src, int i0, int i1)        
            => BitMask.between(src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static ushort between(ushort src, int i0, int i1)        
            => BitMask.between(src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static uint between(uint src, int i0, int i1)        
            => BitMask.between(src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static int between(int src, int i0, int i1)        
            => BitMask.between(src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static ulong between(ulong src, int i0, int i1)
            => BitMask.between(src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static long between(long src, int i0, int i1)
            => BitMask.between(src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static float between(float src, int i0, int i1)
            => BitMask.between(src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static double between(double src, int i0, int i1)
            => BitMask.between(src, i0, i1);

    }

}