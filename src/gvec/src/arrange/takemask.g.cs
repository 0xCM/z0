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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;
    using static z;

    partial class gvec
    {
        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Creates a 16-bit mask from the most significant bit of each byte in the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ushort vtakemask<T>(Vector128<T> src)
            where T : unmanaged
                => (ushort)MoveMask(v8u(src));

        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Creates a 32-bit mask from the most significant bit of each byte in the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static uint vtakemask<T>(Vector256<T> src)
            where T : unmanaged
                => (uint)MoveMask(v8u(src));

        /// <summary>
        /// Creates a 16-bit mask from each byte in the source vector at a byte-relative bit index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">An integer between 0 and 7</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ushort vtakemask<T>(Vector128<T> src, [Imm] byte index)
            where T : unmanaged
                => (ushort)MoveMask(v8u(z.vsll(v64u(src), (byte)(7 - index))));

        /// <summary>
        /// Creates a 32-bit mask from each byte in the source vector at a byte-relative bit index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">An integer between 0 and 7</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static uint vtakemask<T>(Vector256<T> src, [Imm] byte index)
            where T : unmanaged
                => (uint)MoveMask(v8u(z.vsll(v64u(src), (byte)(7 - index))));

        /// <summary>
        /// Creates a 16-bit mask from each byte in the source vector at a byte-relative bit index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">An integer between 0 and 7</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ushort vtakemask<T>(Vector128<T> src, [Imm] HexDigit index)
            where T : unmanaged
                => (ushort)MoveMask(v8u(z.vsll(v64u(src), (byte)(7 - index))));
    }
}