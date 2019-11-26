//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Popcnt;
    using static System.Runtime.Intrinsics.X86.Popcnt.X64;
 
    using static zfunc;
    
    partial class Bits
    {                
        const ulong k1 = 0x5555555555555555;
        
        const ulong k2 = 0x3333333333333333;
        
        const ulong k4 = 0x0f0f0f0f0f0f0f0f;
        
        const ulong kf = 0x0101010101010101; 

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(sbyte src)
            => PopCount((uint)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(byte src)
            => PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(short src)
            => PopCount((uint)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(ushort src)
            => PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(int src)
            => PopCount((uint)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(uint src)
            => PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(long src)
            => (uint)PopCount((ulong)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(ulong src)
            => (uint)PopCount(src);

        [MethodImpl(Inline)]
        public static uint pop(ulong x0, ulong x1)
            => (uint)(PopCount(x0) + PopCount(x1));

        /// <summary>
        /// Computes the population count of the content of 3 64-bit unsigned integers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <remarks>Reference: https://www.chessprogramming.org/Population_Count</remarks>
        [MethodImpl(Inline)]
        public static uint pop(ulong x, ulong y, ulong z) 
        {
            var maj = ((x ^ y ) & z) | (x & y);
            var odd = ((x ^ y ) ^ z);
            
            maj =  maj - ((maj >> 1) & k1 );
            odd =  odd - ((odd >> 1) & k1 );
            
            maj = (maj & k2) + ((maj >> 2) & k2);
            odd = (odd & k2) + ((odd >> 2) & k2);
            
            maj = (maj + (maj >> 4)) & k4;
            odd = (odd + (odd >> 4)) & k4;
            
            odd = ((maj + maj + odd) * kf ) >> 56;
            return (uint) odd;
        }        

        [MethodImpl(Inline)]
        public static uint pop(ulong x0, ulong x1, ulong x2, ulong x3)
            => (uint)(PopCount(x0) + PopCount(x1) + PopCount(x2) + PopCount(x3));

        [MethodImpl(Inline)]
        public static uint pop(ulong x0, ulong x1, ulong x2, ulong x3, ulong x4, ulong x5, ulong x6, ulong x7)
            => pop(x0,x1,x2,x3) + pop(x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static uint pop(ulong x0, ulong x1, ulong x2, ulong x3, ulong x4, ulong x5)
            => pop(x0,x1,x2) + pop(x3,x4,x5);
 
        static uint pop(in ulong src, int len)
        {
            var count = 0u;
            var current = 0;
            do
                count += Bits.pop(skip(in src, current));                
            while(++current < len);

            return count;
        }

        [MethodImpl(Inline)]
        public static uint pop<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => pop(in head(src.AsUInt64()), src.Length);

        [MethodImpl(Inline)]
        public static uint pop<T>(Span<T> src)
            where T : unmanaged
                => pop(in head(src.AsUInt64()), src.Length);
 
    }
}