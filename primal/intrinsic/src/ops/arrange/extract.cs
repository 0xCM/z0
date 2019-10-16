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
    
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse41.X64;
    using static System.Runtime.Intrinsics.X86.Sse42.X64;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// int _mm_extract_epi8 (__m128i a, const int imm8) PEXTRB reg/m8, xmm, imm8
        /// Extracts the value of an identified source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline)]
        public static byte vextract(in Vec128<byte> src, byte pos)
            => Extract(src.xmm, pos);

        /// <summary>
        /// int _mm_extract_epi8 (__m128i a, const int imm8) PEXTRB reg/m8, xmm, imm8
        /// Extracts the value of an identified source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline)]
        public static sbyte vextract(in Vec128<sbyte> src, byte pos)
            => (sbyte)Extract(src.xmm.AsByte(), pos);

        /// <summary>
        /// int _mm_extract_epi16 (__m128i a, int immediate) PEXTRW reg, xmm, imm8
        /// Extracts the value of an identified source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline)]
        public static short vextract(in Vec128<short> src, byte pos)
            => (short)Extract(src.xmm.AsUInt16(), pos);

        /// <summary>
        /// int _mm_extract_epi16 (__m128i a, int immediate) PEXTRW reg, xmm, imm8
        /// Extracts the value of an identified source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline)]
        public static ushort vextract(in Vec128<ushort> src, byte pos)
            => Extract(src.xmm, pos);

        /// <summary>
        /// int _mm_extract_epi32 (__m128i a, const int imm8) PEXTRD reg/m32, xmm, imm8
        /// Extracts the value of an identified source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline)]
        public static int vextract(in Vec128<int> src, byte pos)
            => Extract(src.xmm, pos);

        /// <summary>
        /// int _mm_extract_epi32 (__m128i a, const int imm8) PEXTRD reg/m32, xmm, imm8
        /// Extracts the value of an identified source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline)]
        public static uint vextract(in Vec128<uint> src, byte pos)
            => Extract(src.xmm, pos);

        /// <summary>
        /// __int64 _mm_extract_epi64 (__m128i a, const int imm8) PEXTRQ reg/m64, xmm, imm8
        /// Extracts the value of an identified source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline)]
        public static long vextract(in Vec128<long> src, byte pos)
            => Extract(src.xmm, pos);

        /// <summary>
        /// __int64 _mm_extract_epi64 (__m128i a, const int imm8) PEXTRQ reg/m64, xmm, imm8
        /// Extracts the value of an identified source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline)]
        public static ulong vextract(in Vec128<ulong> src, byte pos)
            => Extract(src.xmm, pos);

    }
}