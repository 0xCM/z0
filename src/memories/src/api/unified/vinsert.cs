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
    using static System.Runtime.Intrinsics.X86.Sse41.X64;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;

    partial class Memories
    {
        /// <summary>
        /// __m128i _mm_insert_epi8 (__m128i a, int i, const int imm8) PINSRB xmm, reg/m8, imm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The cell selector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vinsert(byte src, Vector128<byte> dst, byte index)        
            => Insert(dst, src, index);

        /// <summary>
        ///  __m128i _mm_insert_epi8 (__m128i a, int i, const int imm8)PINSRB xmm, reg/m8, imm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vinsert(sbyte src, Vector128<sbyte> dst, byte index)        
            => Insert(dst, src, index);

        /// <summary>
        /// __m128i _mm_insert_epi16 (__m128i a, int i, int immediate) PINSRW xmm, reg/m16, imm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vinsert(short src, Vector128<short> dst, byte index)        
            => Insert(dst, src, index);

        /// <summary>
        /// __m128i _mm_insert_epi16 (__m128i a, int i, int immediate) PINSRW xmm, reg/m16, imm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vinsert(ushort src, Vector128<ushort> dst, byte index)        
            => Insert(dst, src, index);

        /// <summary>
        /// __m128i _mm_insert_epi32 (__m128i a, int i, const int imm8) PINSRD xmm, reg/m32, xmm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vinsert(int src, Vector128<int> dst, byte index)        
            => Insert(dst, src, index);

        /// <summary>
        /// __m128i _mm_insert_epi32 (__m128i a, int i, const int imm8) PINSRD xmm, reg/m32, xmm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vinsert(uint src, Vector128<uint> dst, byte index)        
            => Insert(dst, src, index);

        /// <summary>
        /// __m128i _mm_insert_epi32 (__m128i a, int i, const int imm8) PINSRD xmm, reg/m32, xmm8
        /// Effects dst[0] = src
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="n">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vinsert(uint src, Vector128<uint> dst, N0 n)        
            => Insert(dst, src, 0);

        /// <summary>
        /// __m128i _mm_insert_epi32 (__m128i a, int i, const int imm8) PINSRD xmm, reg/m32, xmm8
        /// Effects dst[1] = src
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="n">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vinsert(uint src, Vector128<uint> dst, N1 n)        
            => Insert(dst, src, 1);

        /// <summary>
        /// __m128i _mm_insert_epi32 (__m128i a, int i, const int imm8) PINSRD xmm, reg/m32, xmm8
        /// Effects dst[2] = src
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="n">The cell selector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vinsert(uint src, Vector128<uint> dst, N2 n)        
            => Insert(dst, src, 2);
        
        /// <summary>
        /// __m128i _mm_insert_epi32 (__m128i a, int i, const int imm8) PINSRD xmm, reg/m32, xmm8
        /// Effects dst[3] = src
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="n">The cell selector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vinsert(uint src, Vector128<uint> dst, N3 n)        
            => Insert(dst, src, 3);

        /// <summary>
        /// __m128i _mm_insert_epi64 (__m128i a, __int64 i, const int imm8) PINSRQ xmm, reg/m64,imm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vinsert(long src, Vector128<long> dst, byte index)        
            => Insert(dst, src, index);

        /// <summary>
        /// _mm_insert_epi64:
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vinsert(ulong src, Vector128<ulong> dst, byte index)        
            => Insert(dst, src, index);

        /// <summary>
        /// Overwrites an index-indentified cell in an index-identified lane with a specified value
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="laneidx">The lane selector</param>
        /// <param name="cellidx">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vinsert(byte src, Vector256<byte> dst, byte laneidx, byte cellidx)        
            => vlane(vinsert(src,vlane(dst, laneidx), cellidx), dst, 0);

        /// <summary>
        /// Overwrites an index-indentified cell in the first in the lower lane with a specified value
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="lane">The lane selector</param>
        /// <param name="cellidx">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vinsert(byte src, Vector256<byte> dst, N0 lane, byte cellidx)
            => vlane(vinsert(src,vlane(dst, lane), cellidx), dst, 0);

        /// <summary>
        /// Overwrites an index-indentified cell in the upper lane with a specified value
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="lane">The lane selector</param>
        /// <param name="cellidx">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vinsert(byte src, Vector256<byte> dst, N1 lane, byte cellidx)
            => vlane(vinsert(src, vlane(dst, lane), cellidx), dst, 1);

        /// <summary>
        /// Overwrites an index-indentified cell in the lower lane with a specified value
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="lane">The lane selector</param>
        /// <param name="cellidx">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinsert(ushort src, Vector256<ushort> dst, N0 lane, byte cellidx)
            => vlane(vinsert(src,vlane(dst, lane), cellidx), dst, 0);

        /// <summary>
        /// Overwrites an index-indentified cell in the upper lane with a specified value
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="lane">The lane selector</param>
        /// <param name="cellidx">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinsert(ushort src, Vector256<ushort> dst, N1 lane, byte cellidx)        
            => vlane(vinsert(src, vlane(dst, lane), cellidx), dst, 1);

        /// <summary>
        /// Overwrites an index-indentified cell in the lower lane with a specified value
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="lane">The lane selector</param>
        /// <param name="cellidx">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vinsert(uint src, Vector256<uint> dst, N0 lane, byte cellidx)        
            => vlane(vinsert(src,vlane(dst, lane), cellidx), dst, 0);

        /// <summary>
        /// Overwrites an index-indentified cell in the upper lane with a specified value
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="lane">The lane selector</param>
        /// <param name="cellidx">The cell selector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vinsert(uint src, Vector256<uint> dst, N1 lane, byte cellidx)        
            => vlane(vinsert(src, vlane(dst, lane), cellidx), dst, 1);
    }
}