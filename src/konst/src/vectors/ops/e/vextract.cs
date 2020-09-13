//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// int _mm_extract_epi8 (__m128i a, const int imm8) PEXTRB reg/m8, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static sbyte vextract(Vector128<sbyte> src, [Imm] Hex4Kind index)
            => (sbyte)Extract(v8u(src),(byte)index);

        /// <summary>
        /// int _mm_extract_epi8 (__m128i a, const int imm8) PEXTRB reg/m8, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static byte vextract(Vector128<byte> src, [Imm] Hex4Kind index)
            => Extract(src,(byte)index);

        /// <summary>
        /// int _mm_extract_epi16 (__m128i a, int imm8) pextrw r32, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static short vextract(Vector128<short> src, [Imm] Hex3Kind index)
            => (short)Extract(v16u(src),(byte)index);

        /// <summary>
        /// int _mm_extract_epi16 (__m128i a, int imm8) pextrw r32, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static ushort vextract(Vector128<ushort> src, [Imm] Hex3Kind index)
            => Extract(src,(byte)index);

        /// <summary>
        /// int _mm_extract_epi32 (__m128i a, const int imm8) PEXTRD reg/m32, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static uint vextract(Vector128<uint> src, [Imm] Hex2Kind index)
            => Extract(src,(byte)index);

        /// <summary>
        /// int _mm_extract_epi32 (__m128i a, const int imm8) PEXTRD reg/m32, xmm, imm8
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the cell to extract</param>
        [MethodImpl(Inline), Op]
        public static int vextract(Vector128<int> src, [Imm] Hex2Kind index)
            => Extract(src,(byte)index);

        [MethodImpl(Inline), Op]
        public static ushort vextract(Vector256<byte> src, [Imm] Hex5Kind index)
            => src.GetElement((byte)index);

        [MethodImpl(Inline), Op]
        public static ushort vextract(Vector256<ushort> src, [Imm] Hex4Kind index)
            => src.GetElement((byte)index);

        /// <summary>
        /// int _mm_extract_epi8 (__m128i a, const int imm8) PEXTRB reg/m8, xmm, imm8
        /// </summary>
        /// <param name="src"></param>
        /// <param name="n"></param>
        /// <typeparam name="N"></typeparam>
        [MethodImpl(Inline)]
        public static byte vextract<N>(Vector128<byte> src, N n = default)
            where N : unmanaged, ITypeNat
                => vextract(n0,src,n);

        [MethodImpl(Inline), Op]
        public static ushort vextract(Vector128<ushort> src, byte index)
            => (ushort)ConvertToUInt32(v32u(ShiftRightLogical(src, index)));

        [MethodImpl(Inline), Op]
        public static ushort vextract(Vector256<ushort> src, byte index)
            => (ushort)ConvertToUInt32(v32u(ShiftRightLogical(src, index)));

        [MethodImpl(Inline)]
        static byte vextract<N>(N0 first, Vector128<byte> src, N n = default)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N0))
                return Extract(src, 0);
            else if(typeof(N) == typeof(N1))
                return Extract(src, 1);
            else if(typeof(N) == typeof(N2))
                return Extract(src, 2);
            else if(typeof(N) == typeof(N3))
                return Extract(src, 3);
            else if(typeof(N) == typeof(N4))
                return Extract(src, 4);
            else
                return vextract(n5, src, n);
        }

        [MethodImpl(Inline)]
        static byte vextract<N>(N5 first, Vector128<byte> src, N n = default)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N5))
                return Extract(src, 5);
            else if(typeof(N) == typeof(N6))
                return Extract(src, 6);
            else if(typeof(N) == typeof(N7))
                return Extract(src, 7);
            else if(typeof(N) == typeof(N8))
                return Extract(src, 8);
            else if(typeof(N) == typeof(N9))
                return Extract(src, 9);
            else
                return vextract(n10, src, n);
        }

        [MethodImpl(Inline)]
        static byte vextract<N>(N10 first, Vector128<byte> src, N n = default)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N10))
                return Extract(src, 10);
            else if(typeof(N) == typeof(N11))
                return Extract(src, 11);
            else if(typeof(N) == typeof(N12))
                return Extract(src, 12);
            else if(typeof(N) == typeof(N13))
                return Extract(src, 13);
            else if(typeof(N) == typeof(N14))
                return Extract(src, 14);
            else if(typeof(N) == typeof(N14))
                return Extract(src, 15);
            else
                throw no<N>();
        }
    }
}