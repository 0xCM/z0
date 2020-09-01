//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse2.X64;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse.X64;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static z;
    using static Konst;

    partial struct z
    {
        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16u
        /// Projects 16 unsigned 8-bit integers onto 16 unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vmove8x16(in byte src)
            => ConvertToVector256Int16(gptr(src)).AsUInt16();

        /// <summary>
        /// src[3] -> r/m16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target register width</param>
        /// <param name="i">The source component index</param>
        /// <param name="j">THe target component index</param>
        [MethodImpl(Inline), Op]
        public static ushort vmove(Vector128<ushort> src, W16 w, N3 i, N0 j)
            => vmove(vpermlo4x16(src,Perm4L.DBCA), w);

        /// <summary>
        /// src[2] -> r/m16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target register width</param>
        /// <param name="i">The source component index</param>
        /// <param name="j">THe target component index</param>
        [MethodImpl(Inline), Op]
        public static ushort vmove(Vector128<ushort> src, W16 w, N2 i, N0 j)
            => vmove(vpermlo4x16(src,Perm4L.CBDA), w);

        /// <summary>
        /// src[1] -> r/m16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target register width</param>
        /// <param name="i">The source component index</param>
        /// <param name="j">THe target component index</param>
        [MethodImpl(Inline), Op]
        public static ushort vmove(Vector128<ushort> src, W16 w, N1 i, N0 j)
            => vmove(vpermlo4x16(src,Perm4L.BCDA), w);


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
        public static sbyte vmove(Vector128<sbyte> src, N8 w)   
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
        public static byte vmove(Vector128<byte> src, N8 w)   
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
        public static short vmove(Vector128<short> src, N16 w)   
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
        public static ushort vmove(Vector128<ushort> src, W16 w)   
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
        public static int vmove(Vector128<int> src, N32 w)   
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
        public static uint vmove(Vector128<uint> src, N32 w)   
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
        public static long vmove(Vector128<long> src, N64 w)   
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
        public static ulong vmove(Vector128<ulong> src, N64 w)   
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
        public static Vector128<ulong> vmove(Vector128<uint> src, Vector128<ulong> dst)
            => v64u(ConvertScalarToVector128Double(v64f(dst),v32f(src)));

        /// <summary>
        /// src[0..31] -> dst[0..64]
        /// __m128d _mm_cvtss_sd (__m128d a, __m128 b) CVTSS2SD xmm, xmm/m32
        /// Overwrites the lower half of the target vector with the value obtained by converting the least component of the source vector to a 64-bit integer
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vmove(Vector128<int> src, Vector128<long> dst)
            => v64i(ConvertScalarToVector128Double(v64f(dst),v32f(src)));


        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 2x8u -> 2x64u
        /// Projects 2 unsigned 8-bit values onto 2 unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vmove(in byte src, N2 n, W64 w)
            => v64u(ConvertToVector128Int64(z.gptr(src)));

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 4x8u -> 4x32u
        /// Projects 4 unsigned 8-bit values onto 4 unsigned 32-bit values
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vmove(in byte src, N4 n, W32 w)
            => v32u(ConvertToVector128Int32(z.gptr(src)));

        /// <summary>
        /// VPMOVZXBQ ymm, m32
        /// 4x8u -> 4x64u
        /// Projects four unsigned 8-bit integers onto 4 unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vmove(in byte src, N4 n, W64 w)
            => v64u(ConvertToVector256Int64(z.gptr(src)));

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// 8x8u -> 8x16u
        /// Projects 8 8-bit unsigned integers onto 8 16-bit unsigned integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ushort> vmove(in byte src, N8 n, W16 w)
            => v16u(ConvertToVector128Int16(z.gptr(src)));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Projects 8 unsigned 8-bit integers onto 8 unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vmove(in byte src, N8 n, W32 w)
            => v32u(ConvertToVector256Int32(z.gptr(src)));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16u
        /// Projects 16 unsigned 8-bit integers onto 16 unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ushort> vmove(in byte src, N16 n, W16 w)
            => v16u(ConvertToVector256Int16(z.gptr(src)));

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// 2x16u -> 2x64u
        /// Projects 2 unsigned 16-bit integers onto two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vmove(in ushort src, N2 n, W64 w)
            => v64u(ConvertToVector128Int64(z.gptr(src)));

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// 4x16u -> 4x64u
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vmove(in ushort src, N4 n, W64 w)
            => v64u(ConvertToVector256Int64(z.gptr(src)));

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 4x16u -> 4x32u
        /// Projects 4 16-bit unsigned integers onto 4 32-bit unsigned integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vmove(in ushort src, N4 n, W32 w)
            => v32u(ConvertToVector128Int32(z.gptr(in src)));

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 8x16u -> 8x32u
        /// Projects 8 unsigned 16-bit integers onto 8 unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vmove(in ushort src, N8 n, W32 w)
            => v32u(ConvertToVector256Int32(z.gptr(src)));

        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 2x8u -> 2x64i
        /// Projects two unsigned 8-bit integers onto 2 signed 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vmove(in byte src, N2 n, W64 w, N1 i)
            => ConvertToVector128Int64(z.gptr(src));

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 4x8u -> 4x32i
        /// Projects four unsigned 8-bit integers onto 4 signed 32-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vmove(in byte src, N128 w, W32 n, N1 i)
            => ConvertToVector128Int32(z.gptr(src));

        /// <summary>
        /// VPMOVZXBQ ymm, m32
        /// 4x8u -> 4x64i
        /// Projects four unsigned 8-bit integers onto 4 signed 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vmove(in byte src, W256 w, W64 n, N1 i)
            => ConvertToVector256Int64(z.gptr(src));

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// 8x8u -> 8x16u
        /// Projects 8 8-bit unsigned integers onto 8 signed 16-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<short> vmove(in byte src, N8 n, W16 w, N1 i)
            => ConvertToVector128Int16(z.gptr(src));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16i
        /// Projects 16 8-bit unsigned integers onto 16 signed 16-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<short> vmove(in byte src, N16 n, W16 w, N1 i)
            => ConvertToVector256Int16(z.gptr(src));
        
        /// <summary>
        /// PMOVSXWQ xmm, m32
        /// 2x16i -> 2x64u
        /// Projects 2 16-bit signed integers onto 2 64-bit signed integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vmove(in short src, N2 n, W64 w)
            => ConvertToVector128Int64(z.gptr(src));

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 4x16i -> 4x32i
        /// Projects 4 16-bit signed integers onto 4 32-bit signed integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vmove(in short src, N4 n, W32 w)
            => ConvertToVector128Int32(z.gptr(src));

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// Projects 2 unsigned 16-bit integers onto 2 signed 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vmove(in ushort src, N2 n, W64 w, N1 i)
            => ConvertToVector128Int64(z.gptr(src));

        /// <summary>
        /// PMOVSXDQ xmm, m64
        /// 2x32i -> 2x64i
        /// Projects 2 signed 32-bit integers onto 2 signed 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vmove(in int src, N2 n, W64 w)
            => ConvertToVector128Int64(z.gptr(src));

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 16x16u ->16x32u
        /// Projects 16 unsigned 16-bit integers onto 16 unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<uint> vmove(in ushort src, N16 n, W32 w)
            => (v32u(ConvertToVector256Int32(z.gptr(src))),
                v32u(ConvertToVector256Int32(z.gptr(src, 8))));

        /// <summary>
        /// VPMOVSXWD ymm, m128
        /// 16x16u ->16x32u
        /// Projects 16 signed 16-bit integers onto 16 signed 32-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<int> vmove(in short src, N16 n, W32 w)
            => (ConvertToVector256Int32(z.gptr(in src)),
                ConvertToVector256Int32(z.gptr(in src, 8)));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 32x8u -> 32x16u
        /// Projects 32 unsigned 8-bit integers onto 32 unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<ushort> vmove(in byte src, N32 n, W16 w)
            => (v16u(ConvertToVector256Int16(z.gptr(src))),
                v16u(ConvertToVector256Int16(z.gptr(src,16))));

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// 8x16u -> 8x64u
        /// Projects 8 unsigned 16-bit integers onto 8 unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<ulong> vmove(in ushort src, N8 n, W64 w)
            => (v64u(ConvertToVector256Int64(z.gptr(src))),
                v64u(ConvertToVector256Int64(z.gptr(src,4))));

        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// 8x32u -> 8x64u
        /// Projects 8 unsigned 32-bit integers onto 8 unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<ulong> vmove(in uint src, N8 n, W64 w)
            => (v64u(ConvertToVector256Int64(z.gptr(src))),
                v64u(ConvertToVector256Int64(z.gptr(src,4)))); 
    }
}