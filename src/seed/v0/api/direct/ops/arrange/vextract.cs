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
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static Konst;
    using static As;

    partial struct V0d
    {
        /// <summary>
        /// int _mm_extract_epi8 (__m128i a, const int imm8) PEXTRB reg/m8, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static sbyte vextract(Vector128<sbyte> src, [Imm] HexKind4 index)
            => (sbyte)Extract(v8u(src),(byte)index);

        /// <summary>
        /// int _mm_extract_epi8 (__m128i a, const int imm8) PEXTRB reg/m8, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static byte vextract(Vector128<byte> src, [Imm] HexKind4 index)
            => Extract(src,(byte)index);
        
        /// <summary>
        /// int _mm_extract_epi16 (__m128i a, int imm8) pextrw r32, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static short vextract(Vector128<short> src, [Imm] HexKind3 index)
            => (short)Extract(v16u(src),(byte)index);

        /// <summary>
        /// int _mm_extract_epi16 (__m128i a, int imm8) pextrw r32, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static ushort vextract(Vector128<ushort> src, [Imm] HexKind3 index)
            => Extract(src,(byte)index);

        /// <summary>
        /// int _mm_extract_epi32 (__m128i a, const int imm8) PEXTRD reg/m32, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static uint vextract(Vector128<uint> src, [Imm] HexKind2 index)
            => Extract(src,(byte)index);

        /// <summary>
        /// int _mm_extract_epi32 (__m128i a, const int imm8) PEXTRD reg/m32, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static int vextract(Vector128<int> src, [Imm] HexKind2 index)
            => Extract(src,(byte)index);

        [MethodImpl(Inline), Op]
        public static ushort vextract(Vector256<byte> src, [Imm] HexKind5 index)   
            => src.GetElement((byte)index);

        [MethodImpl(Inline), Op]
        public static ushort vextract(Vector256<ushort> src, [Imm] HexKind4 index)   
            => src.GetElement((byte)index);
    }
}