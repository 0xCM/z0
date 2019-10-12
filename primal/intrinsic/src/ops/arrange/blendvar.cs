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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
        
    using static zfunc;
    
    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask)PBLENDVB xmm, xmm/m128, xmm
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vblendvar(in Vec128<byte> x, in Vec128<byte> y, in Vec128<byte> spec)        
            =>  BlendVariable(x.xmm, y.xmm, spec);

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component,
        /// z[i] = testbit(spec[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vblendvar(in Vec256<sbyte> x, in Vec256<sbyte> y, in Vec256<sbyte> spec)        
            => BlendVariable(x.ymm, y.ymm, spec);

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component,
        /// z[i] = testbit(spec[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendvb</remarks>
        [MethodImpl(Inline)]
        public static Vec256<byte> vblendvar(in Vec256<byte> x, in Vec256<byte> y, in Vec256<byte> spec)        
            =>  BlendVariable(x.ymm, y.ymm, spec);

        /// <summary>
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component,
        /// z[i] = testbit(spec[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vblendvar(in Vec256<short> x, in Vec256<short> y, in Vec256<short> spec)        
            => BlendVariable(x.ymm, y.ymm, spec);

        /// <summary>
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component,
        /// z[i] = testbit(spec[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vblendvar(in Vec256<ushort> x, in Vec256<ushort> y, in Vec256<ushort> spec)        
            => BlendVariable(x.ymm, y.ymm, spec);

        /// <summary>
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component,
        /// z[i] = testbit(spec[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vblendvar(in Vec256<int> x, in Vec256<int> y, in Vec256<int> spec)        
            => BlendVariable(x.ymm, y.ymm, spec);

        /// <summary>
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component,
        /// z[i] = testbit(spec[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vblendvar(in Vec256<uint> x, in Vec256<uint> y, in Vec256<uint> spec)        
            => BlendVariable(x.ymm, y.ymm, spec);

        /// <summary>
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component,
        /// z[i] = testbit(spec[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vblendvar(in Vec256<long> x, in Vec256<long> y, in Vec256<long> spec)        
            => BlendVariable(x.ymm, y.ymm, spec);

        /// <summary>
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component,
        /// z[i] = testbit(spec[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vblendvar(in Vec256<ulong> x, in Vec256<ulong> y, in Vec256<ulong> spec)        
            => BlendVariable(x.ymm, y.ymm, spec);
    }

}