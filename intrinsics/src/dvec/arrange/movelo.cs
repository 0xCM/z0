//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse2.X64;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse.X64;
     
    using static Core;
    using static vgeneric;

    partial class dvec
    {
        /// <summary>
        /// src[0..31] -> dst[0..31]
        /// __m128 _mm_cvtsi32_ss (__m128 a, int b) CVTSI2SS xmm, reg/m32
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vmovelo(int src, Vector128<float> dst)
            => ConvertScalarToVector128Single(dst,src);

        /// <summary>
        /// src[0..31] -> dst[0..63]
        ///  __m128d _mm_cvtsi32_sd (__m128d a, int b) CVTSI2SD xmm, reg/m32
        /// Overwrites the lower half of the target vector with the value obtained by converting the source value to a 64-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vmovelo(int src, Vector128<double> dst)
            => ConvertScalarToVector128Double(dst,src);

        /// <summary>
        /// src[0..63] -> dst[0..63]
        ///  __m128d _mm_cvtsi64_sd (__m128d a, __int64 b) CVTSI2SD xmm, reg/m64
        /// Overwrites the lower half of the target vector with the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vmovelo(long src, Vector128<double> dst)
            => ConvertScalarToVector128Double(dst,src);

        /// <summary>
        /// src[0..7] -> r/m8[0..31]
        /// int _mm_cvtsi128_si32 (__m128i a)MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        /// <remarks>
        /// vmovupd xmm0,[rcx] |> vmovd eax,xmm0 |> movzx rax,al
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static sbyte vmovelo(Vector128<sbyte> src, N8 w)   
            => (sbyte)ConvertToInt32(v32i(src));

        /// <summary>
        /// src[0..7] -> r/m8[0..31]
        /// int _mm_cvtsi128_si32 (__m128i a)MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        /// <remarks>
        /// vmovupd xmm0,[rcx] |> vmovd eax,xmm0 |> movzx eax,al
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static byte vmovelo(Vector128<byte> src, N8 w)   
            => (byte)ConvertToUInt32(v32u(src));

        /// <summary>
        /// src[0..15] -> r/m16[0..31]
        /// int _mm_cvtsi128_si32 (__m128i a)MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        /// <remarks>
        /// vmovupd xmm0,[rcx] |> vmovd eax,xmm0 |> movsx rax,ax |> 
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static short vmovelo(Vector128<short> src, N16 w)   
            => (short)ConvertToInt32(v32i(src));

        /// <summary>
        /// src[0..15] -> r/m16[0..31]
        /// int _mm_cvtsi128_si32 (__m128i a)MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        /// <remarks>
        /// vmovupd xmm0,[rcx] |> vmovd eax,xmm0 |> movsx eax,ax
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static ushort vmovelo(Vector128<ushort> src, N16 w)   
            => (ushort)ConvertToUInt32(v32u(src));

        /// <summary>
        /// src[0..31] -> r/m32[0..31]
        /// int _mm_cvtsi128_si32 (__m128i a) MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        /// <remarks>
        /// vmovupd xmm0,[rcx] |> vmovd eax,xmm0
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static int vmovelo(Vector128<int> src, N32 w)   
            => ConvertToInt32(src);

        /// <summary>
        /// src[0..31] -> r/m32[0..31]
        /// int _mm_cvtsi128_si32 (__m128i a) MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        /// <remarks>
        /// vmovupd xmm0,[rcx] |> vmovd eax,xmm0
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static uint vmovelo(Vector128<uint> src, N32 w)   
            => ConvertToUInt32(src);

        /// <summary>
        /// src[0..64] -> r/m32[0..64]
        /// __int64 _mm_cvtsi128_si64 (__m128i a) MOVQ reg/m64, xmm
        /// Moves the lower half of the source vector to a 64-bit register
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target type representative</param>
        /// <remarks>
        /// vmovupd xmm0,[rcx] |> vmovq rax,xmm0 
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static long vmovelo(Vector128<long> src, N64 w)   
            => ConvertToInt64(src);

        /// <summary>
        /// src[0..64] -> r/m32[0..64]
        /// __int64 _mm_cvtsi128_si64 (__m128i a) MOVQ reg/m64, xmm
        /// Moves the lower half of the source vector to a 64-bit register
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target type representative</param>
        /// <remarks>
        /// vmovupd xmm0,[rcx] |> vmovq rax,xmm0 
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static ulong vmovelo(Vector128<ulong> src, N64 w)   
            => ConvertToUInt64(src);        

        /// <summary>
        /// src[0..31] -> dst[0..64]
        /// __m128d _mm_cvtss_sd (__m128d a, __m128 b) CVTSS2SD xmm, xmm/m32
        /// Overwrites the lower half of the target vector with the value obtained by converting the 
        /// least component of the source vector to a 64-bit integer
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vmovelo(Vector128<uint> src, Vector128<ulong> dst)
            => v64u(ConvertScalarToVector128Double(v64f(dst),v32f(src)));

        /// <summary>
        /// src[0..31] -> dst[0..64]
        /// __m128d _mm_cvtss_sd (__m128d a, __m128 b) CVTSS2SD xmm, xmm/m32
        /// Overwrites the lower half of the target vector with the value obtained by converting the least component of the source vector to a 64-bit integer
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vmovelo(Vector128<int> src, Vector128<long> dst)
            => v64i(ConvertScalarToVector128Double(v64f(dst),v32f(src)));

        /// <summary>
        /// src[0..31] -> dst[0..64]
        /// __m128d _mm_cvtss_sd (__m128d a, __m128 b) CVTSS2SD xmm, xmm/m32
        /// Overwrites the lower half of the target vector with the value obtained by converting the least component of the source vector to a 64-bit integer
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vmovelo(Vector128<float> src, Vector128<double> dst)
            => ConvertScalarToVector128Double(dst,src);
    }
}