//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
     
    using static Seed; 
    using static Memories;
    using static AsIn;

    [ApiHost]
    public readonly struct VSpreads : IApiHost<VSpreads>
    {
        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 2x8u -> 2x64u
        /// Projects 2 unsigned 8-bit values onto 2 unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector128<ulong> vspread(in byte src, N2 n, W64 w)
            => v64u(ConvertToVector128Int64(constptr(in src)));

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 4x8u -> 4x32u
        /// Projects 4 unsigned 8-bit values onto 4 unsigned 32-bit values
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector128<uint> vspread(in byte src, N4 n, W32 w)
            => v32u(ConvertToVector128Int32(constptr(in src)));

        /// <summary>
        /// VPMOVZXBQ ymm, m32
        /// 4x8u -> 4x64u
        /// Projects four unsigned 8-bit integers onto 4 unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector256<ulong> vspread(in byte src, N4 n, W64 w)
            => v64u(ConvertToVector256Int64(constptr(in src)));

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// 8x8u -> 8x16u
        /// Projects 8 8-bit unsigned integers onto 8 16-bit unsigned integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector128<ushort> vspread(in byte src, N8 n, W16 w)
            => v16u(ConvertToVector128Int16(constptr(in src)));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Projects 8 unsigned 8-bit integers onto 8 unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector256<uint> vspread(in byte src, N8 n, W32 w)
            => v32u(ConvertToVector256Int32(constptr(in src)));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16u
        /// Projects 16 unsigned 8-bit integers onto 16 unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector256<ushort> vspread(in byte src, N16 n, W16 w)
            => v16u(ConvertToVector256Int16(constptr(in src)));

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// 2x16u -> 2x64u
        /// Projects 2 unsigned 16-bit integers onto two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector128<ulong> vspread(in ushort src, N2 n, W64 w)
            => v64u(ConvertToVector128Int64(constptr(src)));

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// 4x16u -> 4x64u
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector256<ulong> vspread(in ushort src, N4 n, W64 w)
            => v64u(ConvertToVector256Int64(constptr(src)));

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 4x16u -> 4x32u
        /// Projects 4 16-bit unsigned integers onto 4 32-bit unsigned integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector128<uint> vspread(in ushort src, N4 n, W32 w)
            => v32u(ConvertToVector128Int32(constptr(in src)));

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 8x16u -> 8x32u
        /// Projects 8 unsigned 16-bit integers onto 8 unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector256<uint> vspread(in ushort src, N8 n, W32 w)
            => v32u(ConvertToVector256Int32(constptr(src)));

        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 2x8u -> 2x64i
        /// Projects two unsigned 8-bit integers onto 2 signed 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector128<long> vspread(in byte src, N2 n, W64 w, N1 i)
            => ConvertToVector128Int64(constptr(in src));

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 4x8u -> 4x32i
        /// Projects four unsigned 8-bit integers onto 4 signed 32-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector128<int> vspread(in byte src, N128 w, W32 n, N1 i)
            => ConvertToVector128Int32(constptr(src));

        /// <summary>
        /// VPMOVZXBQ ymm, m32
        /// 4x8u -> 4x64i
        /// Projects four unsigned 8-bit integers onto 4 signed 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector256<long> vspread(in byte src, W256 w, W64 n, N1 i)
            => ConvertToVector256Int64(constptr(src));

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// 8x8u -> 8x16u
        /// Projects 8 8-bit unsigned integers onto 8 signed 16-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector128<short> vspread(in byte src, N8 n, W16 w, N1 i)
            => ConvertToVector128Int16(constptr(src));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16i
        /// Projects 16 8-bit unsigned integers onto 16 signed 16-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector256<short> vspread(in byte src, N16 n, W16 w, N1 i)
            => ConvertToVector256Int16(constptr(src));
        
        /// <summary>
        /// PMOVSXWQ xmm, m32
        /// 2x16i -> 2x64u
        /// Projects 2 16-bit signed integers onto 2 64-bit signed integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector128<long> vspread(in short src, N2 n, W64 w)
            => ConvertToVector128Int64(constptr(src));

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 4x16i -> 4x32i
        /// Projects 4 16-bit signed integers onto 4 32-bit signed integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector128<int> vspread(in short src, N4 n, W32 w)
            => ConvertToVector128Int32(constptr(src));

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// Projects 2 unsigned 16-bit integers onto 2 signed 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector128<long> vspread(in ushort src, N2 n, W64 w, N1 i)
            => ConvertToVector128Int64(constptr(src));

        /// <summary>
        /// PMOVSXDQ xmm, m64
        /// 2x32i -> 2x64i
        /// Projects 2 signed 32-bit integers onto 2 signed 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector128<long> vspread(in int src, N2 n, W64 w)
            => ConvertToVector128Int64(constptr(in src));

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 16x16u ->16x32u
        /// Projects 16 unsigned 16-bit integers onto 16 unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector512<uint> vspread(in ushort src, N16 n, W32 w)
            => (v32u(ConvertToVector256Int32(constptr(in src))),
                v32u(ConvertToVector256Int32(constptr(in src, 8))));

        /// <summary>
        /// VPMOVSXWD ymm, m128
        /// 16x16u ->16x32u
        /// Projects 16 signed 16-bit integers onto 16 signed 32-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector512<int> vspread(in short src, N16 n, W32 w)
            => (ConvertToVector256Int32(constptr(in src)),
                ConvertToVector256Int32(constptr(in src, 8)));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 32x8u -> 32x16u
        /// Projects 32 unsigned 8-bit integers onto 32 unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector512<ushort> vspread(in byte src, N32 n, W16 w)
            => (v16u(ConvertToVector256Int16(constptr(in src))),
                v16u(ConvertToVector256Int16(constptr(in src,16))));

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// 8x16u -> 8x64u
        /// Projects 8 unsigned 16-bit integers onto 8 unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector512<ulong> vspread(in ushort src, N8 n, W64 w)
            => (v64u(ConvertToVector256Int64(constptr(in src))),
                v64u(ConvertToVector256Int64(constptr(in src,4))));

        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// 8x32u -> 8x64u
        /// Projects 8 unsigned 32-bit integers onto 8 unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline), VMap]
        public static unsafe Vector512<ulong> vspread(in uint src, N8 n, W64 w)
            => (v64u(ConvertToVector256Int64(constptr(in src))),
                v64u(ConvertToVector256Int64(constptr(in src,4)))); 
    }
}
