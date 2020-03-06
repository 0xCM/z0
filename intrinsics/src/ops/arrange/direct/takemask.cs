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

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Root;
    using static gvec;

    partial class dinx
    {
        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static ushort vtakemask(Vector128<byte> src)
            => (ushort)MoveMask(src);

        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static ushort vtakemask(Vector128<ushort> src)
            => (ushort)MoveMask(v8u(src));

        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static ushort vtakemask(Vector128<uint> src)
            => (ushort)MoveMask(v8u(src));

        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static ushort vtakemask(Vector128<ulong> src)
            => (ushort)MoveMask(v8u(src));

        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static uint vtakemask(Vector256<byte> src)
            => (uint)MoveMask(src);

        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static uint vtakemask(Vector256<ushort> src)
            => (uint)MoveMask(v8u(src));

        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static uint vtakemask(Vector256<uint> src)
            => (uint)MoveMask(v8u(src));

        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Constructs an integer from the most significant bit of each 8-bit source vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static uint vtakemask(Vector256<ulong> src)
            => (uint)MoveMask(v8u(src));

        /// <summary>
        /// Creates a 32-bit mask from each byte at a byte-relative bit index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">An integer between 0 and 7</param>
        [MethodImpl(Inline), Op]
        public static ushort vtakemask(Vector128<byte> src, [Imm] byte index)
            => vtakemask(vsll(v64u(src), (byte)(7 - index)));

        /// <summary>
        /// Creates a 32-bit mask from each byte at a byte-relative bit index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">An integer between 0 and 7</param>
        [MethodImpl(Inline), Op]
        public static ushort vtakemask(Vector128<ushort> src, [Imm] byte index)
            => vtakemask(vsll(v64u(src), (byte)(7 - index)));

        /// <summary>
        /// Creates a 32-bit mask from each byte at a byte-relative bit index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">An integer between 0 and 7</param>
        [MethodImpl(Inline), Op]
        public static ushort vtakemask(Vector128<uint> src, [Imm] byte index)
            => vtakemask(vsll(v64u(src), (byte)(7 - index)));

        /// <summary>
        /// Creates a 32-bit mask from each byte at a byte-relative bit index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">An integer between 0 and 7</param>
        [MethodImpl(Inline), Op]
        public static ushort vtakemask(Vector128<ulong> src, [Imm] byte index)
            => vtakemask(vsll(v64u(src), (byte)(7 - index)));

        /// <summary>
        /// Creates a 32-bit mask from each byte at a byte-relative bit index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">An integer between 0 and 7</param>
        [MethodImpl(Inline), Op]
        public static uint vtakemask(Vector256<byte> src, [Imm] byte index)
            => vtakemask(vsll(v64u(src), (byte)(7 - index)));

        /// <summary>
        /// Creates a 32-bit mask from each byte at a byte-relative bit index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">An integer between 0 and 7</param>
        [MethodImpl(Inline), Op]
        public static uint vtakemask(Vector256<ushort> src, [Imm] byte index)
            => vtakemask(vsll(v64u(src), (byte)(7 - index)));

        /// <summary>
        /// Creates a 32-bit mask from each byte at a byte-relative bit index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">An integer between 0 and 7</param>
        [MethodImpl(Inline), Op]
        public static uint vtakemask(Vector256<uint> src, [Imm] byte index)
            => vtakemask(vsll(src, (byte)(7 - index)));

        /// <summary>
        /// Creates a 32-bit mask from each byte at a byte-relative bit index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">An integer between 0 and 7</param>
        [MethodImpl(Inline), Op]
        public static uint vtakemask(Vector256<ulong> src, [Imm] byte index)
            => vtakemask(vsll(src, (byte)(7 - index)));

        [MethodImpl(Inline), Op]
        public static ushort vtakemask(Vector128<byte> src, byte offset, [Imm] byte index)
            => vtakemask(vsllx(src, offset), index);   

        [MethodImpl(Inline), Op]
        public static ushort vtakemask(Vector128<ushort> src, byte offset, [Imm] byte index)
            => vtakemask(vsllx(src, offset), index);   

        [MethodImpl(Inline), Op]
        public static ushort vtakemask(Vector128<uint> src, Vector128<uint> offsets, [Imm] byte index)
            => vtakemask(vsllv(src, offsets), index);   

        [MethodImpl(Inline), Op]
        public static ushort vtakemask(Vector128<ulong> src, Vector128<ulong> offsets, [Imm] byte index)
            => vtakemask(vsllv(src, offsets), index);   

        [MethodImpl(Inline), Op]
        public static uint vtakemask(Vector256<byte> src, [Imm] byte offset, [Imm] byte index)
            => vtakemask(vsllx(src, offset), index);   

        [MethodImpl(Inline), Op]
        public static uint vtakemask(Vector256<ushort> src, [Imm] byte offset, [Imm] byte index)
            => vtakemask(vsllx(src, offset), index);   

        [MethodImpl(Inline), Op]
        public static uint vtakemask(Vector256<uint> src, Vector256<uint> offsets, [Imm] byte index)
            => vtakemask(vsllv(src, offsets), index);   

        [MethodImpl(Inline), Op]
        public static uint vtakemask(Vector256<ulong> src, Vector256<ulong> offsets, [Imm] byte index)
            => vtakemask(vsllv(src, offsets), index);   
    }
}