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
        public static int ntz(sbyte src)
           => (int)TrailingZeroCount((uint)src);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int ntz(byte src)
           => (int)TrailingZeroCount((uint)src);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int ntz(short src)
           => (int)TrailingZeroCount((uint)src);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int ntz(ushort src)
            => (int)TrailingZeroCount((uint)src);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
         [MethodImpl(Inline)]
         public static int ntz(int src)
            => (int)TrailingZeroCount((uint)src);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int ntz(uint src)
            => (int)TrailingZeroCount(src);

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
         [MethodImpl(Inline)]
         public static int ntz(long src)
            => (int)TrailingZeroCount((ulong)src);

        /// <summary>
        /// __int64 _mm_tzcnt_64 (unsigned __int64 a) TZCNT reg, reg/m64
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int ntz(ulong src)
            => (int) TrailingZeroCount(src);
    }
}