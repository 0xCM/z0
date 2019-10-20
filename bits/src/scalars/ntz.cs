//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;

    using static zfunc;
    
    partial class Bits
    {                
        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint ntz(sbyte src)
           => (uint)TrailingZeroCount((uint)src);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint ntz(byte src)
           => (uint)TrailingZeroCount(src);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint ntz(short src)
           => (uint)TrailingZeroCount((uint)src);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint ntz(ushort src)
             => (uint)TrailingZeroCount(src);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
         [MethodImpl(Inline)]
         public static uint ntz(int src)
            => (uint)TrailingZeroCount((uint)src);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint ntz(uint src)
            => (uint)TrailingZeroCount(src);

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
         [MethodImpl(Inline)]
         public static uint ntz(long src)
            => (uint)TrailingZeroCount((ulong)src);

        /// <summary>
        /// __int64 _mm_tzcnt_64 (unsigned __int64 a) TZCNT reg, reg/m64
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint ntz(ulong src)
            =>(uint) TrailingZeroCount(src);
    }
}