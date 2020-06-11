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
    using static System.Runtime.Intrinsics.X86.Sse42;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;
    
    using static Seed;
    using static Vectors;

    partial class dvec
    {
        /// <summary>
        /// int _mm_extract_epi8 (__m128i a, const int imm8) PEXTRB reg/m8, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static sbyte vextract(Vector128<sbyte> src, [Imm] Hex4 index)
            => (sbyte)Extract(v8u(src),(byte)index);

        /// <summary>
        /// int _mm_extract_epi8 (__m128i a, const int imm8) PEXTRB reg/m8, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static byte vextract(Vector128<byte> src, [Imm] Hex4 index)
            => Extract(src,(byte)index);
        
        /// <summary>
        /// int _mm_extract_epi16 (__m128i a, int imm8) pextrw r32, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static short vextract(Vector128<short> src, [Imm] Hex3 index)
            => (short)Extract(v16u(src),(byte)index);

        /// <summary>
        /// int _mm_extract_epi16 (__m128i a, int imm8) pextrw r32, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static ushort vextract(Vector128<ushort> src, [Imm] Hex3 index)
            => Extract(src,(byte)index);

        /// <summary>
        /// int _mm_extract_epi32 (__m128i a, const int imm8) PEXTRD reg/m32, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static uint vextract(Vector128<uint> src, [Imm] Hex2 index)
            => Extract(src,(byte)index);

        /// <summary>
        /// int _mm_extract_epi32 (__m128i a, const int imm8) PEXTRD reg/m32, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static int vextract(Vector128<int> src, [Imm] Hex2 index)
            => Extract(src,(byte)index);
    }
}