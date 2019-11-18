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
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;    
    
    using static zfunc;

    partial class dinx    
    {                
        /// <summary>
        /// __m128i _mm_loadl_epi32 (__m128i const* mem_addr) MOVD xmm, reg/m32
        /// Loads a 32-bit value into the lo 32 bits of a 128-bit vector
        /// </summary>
        /// <param name="m32">The source value</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vloadlo(int m32)
            => LoadScalarVector128(&m32);

        /// <summary>
        /// __m128i _mm_loadl_epi32 (__m128i const* mem_addr) MOVD xmm, reg/m32
        /// Loads a 32-bit value into the lo 32 bits of a 128-bit vector
        /// </summary>
        /// <param name="m32">The source value</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vloadlo(uint m32)
            => LoadScalarVector128(&m32);

        /// <summary>
        /// __m128i _mm_loadl_epi64 (__m128i const* mem_addr) MOVQ xmm, reg/m64
        /// Loads a 64-bit value into the lo 64 bits of a 128-bit vector
        /// </summary>
        /// <param name="m64">The source value</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vloadlo(long m64)
            => LoadScalarVector128(&m64);

        /// <summary>
        ///  __m128i _mm_loadl_epi64 (__m128i const* mem_addr) MOVQ xmm, reg/m64
        /// Loads a 64-bit value into the lo 64 bits of a 128-bit vector
        /// </summary>
        /// <param name="m64">The source value</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vloadlo(ulong m64)
            => LoadScalarVector128(&m64);
    }
}