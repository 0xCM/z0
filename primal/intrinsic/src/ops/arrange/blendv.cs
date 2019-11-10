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
        public static Vector128<byte> vblendv(Vector128<byte> x, Vector128<byte> y, Vector128<byte> spec)        
            =>  BlendVariable(x, y, spec);

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
        public static Vector256<sbyte> vblendv(Vector256<sbyte> x, Vector256<sbyte> y, Vector256<sbyte> spec)        
            => BlendVariable(x, y, spec);

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
        public static Vector256<byte> vblendv(Vector256<byte> x, Vector256<byte> y, Vector256<byte> spec)        
            =>  BlendVariable(x, y, spec);

        /// <summary>
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component,
        /// z[i] = testbit(spec[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vblendv(Vector256<short> x, Vector256<short> y, Vector256<short> spec)        
            => BlendVariable(x, y, spec);

        /// <summary>
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component,
        /// z[i] = testbit(spec[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vblendv(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> spec)        
            => BlendVariable(x, y, spec);

        /// <summary>
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component,
        /// z[i] = testbit(spec[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vblendv(Vector256<int> x, Vector256<int> y, Vector256<int> spec)        
            => BlendVariable(x, y, spec);

        /// <summary>
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component,
        /// z[i] = testbit(spec[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vblendv(Vector256<uint> x, Vector256<uint> y, Vector256<uint> spec)        
            => BlendVariable(x, y, spec);

        /// <summary>
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component, z[i] = testbit(spec[i],63) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vblendv(Vector256<long> x, Vector256<long> y, Vector256<long> spec)        
            => BlendVariable(x, y, spec);

        /// <summary>
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component, z[i] = testbit(spec[i],7) ? y[i] : x[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vblendv(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> spec)        
            => BlendVariable(x, y, spec);

        /// <summary>
        /// __m256 _mm256_blendv_ps (__m256 a, __m256 b, __m256 mask) VBLENDVPS ymm, ymm, ymm/m256, ymm
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component, z[i] = testbit(spec[i],31) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vblendv(Vector256<float> x, Vector256<float> y, Vector256<float> spec)        
            => BlendVariable(x, y, spec);

        /// <summary>
        /// __m256d _mm256_blendv_pd (__m256d a, __m256d b, __m256d mask)VBLENDVPD ymm, ymm, ymm/m256, ymm
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component, z[i] = testbit(spec[i],63) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vblendv(Vector256<double> x, Vector256<double> y, Vector256<double> spec)        
            => BlendVariable(x, y, spec);
    }

}