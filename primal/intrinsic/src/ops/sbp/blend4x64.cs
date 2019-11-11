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
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component, z[i] = testbit(spec[i],63) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vblend4x64(Vector256<long> x, Vector256<long> y, Vector256<long> spec)        
            => BlendVariable(x, y, spec);

        /// <summary>
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component, z[i] = testbit(spec[i],7) ? y[i] : x[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vblend4x64(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> spec)        
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
        public static Vector256<double> vblend4x64(Vector256<double> x, Vector256<double> y, Vector256<double> spec)        
            => BlendVariable(x, y, spec);
    }

}