//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;
    using static Vectors;
    using static Typed;

    partial class dvec
    {
        /// <summary>
        /// __m128i _mm_cmpgt_epi8 (__m128i a, __m128i b) PCMPGTB xmm, xmm/m128
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Gt]
        public static Vector128<sbyte> vgt(Vector128<sbyte> x, Vector128<sbyte> y)
            => CompareGreaterThan(x,y);

        /// <summary>
        /// __m128i _mm_cmpgt_epi8 (__m128i a, __m128i b) PCMPGTB xmm, xmm/m128
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Gt]
        public static Vector128<byte> vgt(Vector128<byte> x, Vector128<byte> y)
        {
            var mask = z.vbroadcast(n128,CmpMask8u);
            var mx = vxor(x,mask).AsSByte();
            var my = vxor(y,mask).AsSByte();
            return CompareGreaterThan(mx,my).AsByte();
        }

        /// <summary>
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Gt]
        public static Vector128<short> vgt(Vector128<short> x, Vector128<short> y)
            => CompareGreaterThan(x,y);

        /// <summary>
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Gt]
        public static Vector128<ushort> vgt(Vector128<ushort> x, Vector128<ushort> y)
        {
            var mask = z.vbroadcast(n128,CmpMask16u);
            var mx = vxor(x,mask).AsInt16();
            var my = vxor(y,mask).AsInt16();
            return CompareGreaterThan(mx,my).AsUInt16();
        }

        /// <summary>
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Gt]
        public static Vector128<int> vgt(Vector128<int> x, Vector128<int> y)
            => CompareGreaterThan(x,y);

        /// <summary>
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Gt]
        public static Vector128<uint> vgt(Vector128<uint> x, Vector128<uint> y)
        {
            var mask = z.vbroadcast(n128,CmpMask32u);
            var mx = vxor(x,mask).AsInt32();
            var my = vxor(y,mask).AsInt32();
            return CompareGreaterThan(mx,my).AsUInt32();
        }

        /// <summary>
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Gt]
        public static Vector128<long> vgt(Vector128<long> x, Vector128<long> y)
        {
            var a = z.vinsert(x,default, BitState.Off);
            var b = z.vinsert(y,default, BitState.Off);
            return z.vlo(vgt(a,b));
        }

        /// <summary>
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline),Gt]
        public static Vector128<ulong> vgt(Vector128<ulong> x, Vector128<ulong> y)
        {
            var mask = z.vbroadcast(n128,CmpMask64u);
            var mx = v64i(vxor(x,mask));
            var my = v64i(vxor(y,mask));
            return v64u(vgt(mx,my));
        }

        /// <summary>
        /// __m256i _mm256_cmpgt_epi8 (__m256i a, __m256i b) VPCMPGTB ymm, ymm, ymm/m256
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Gt]
        public static Vector256<sbyte> vgt(Vector256<sbyte> x, Vector256<sbyte> y)
            => CompareGreaterThan(x,y);

        /// <summary>
        /// __m256i _mm256_cmpgt_epi8 (__m256i a, __m256i b) VPCMPGTB ymm, ymm, ymm/m256
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Gt]
        public static Vector256<byte> vgt(Vector256<byte> x, Vector256<byte> y)
        {
            var mask = z.vbroadcast(n256,CmpMask8u);
            var mx = vxor(x,mask).AsSByte();
            var my = vxor(y,mask).AsSByte();
            return CompareGreaterThan(mx,my).AsByte();
        }

        /// <summary>
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Gt]
        public static Vector256<short> vgt(Vector256<short> x, Vector256<short> y)
            => CompareGreaterThan(x,y);

        /// <summary>
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Gt]
        public static Vector256<ushort> vgt(Vector256<ushort> x, Vector256<ushort> y)
        {
            var mask = z.vbroadcast(n256,CmpMask16u);
            var mx = vxor(x,mask).AsInt16();
            var my = vxor(y,mask).AsInt16();
            return CompareGreaterThan(mx,my).AsUInt16();
        }

        /// <summary>
        /// __m256i _mm256_cmpgt_epi32 (__m256i a, __m256i b) VPCMPGTD ymm, ymm, ymm/m256
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Gt]
        public static Vector256<int> vgt(Vector256<int> x, Vector256<int> y)
            => CompareGreaterThan(x,y);

        /// <summary>
        /// __m256i _mm256_cmpgt_epi32 (__m256i a, __m256i b) VPCMPGTD ymm, ymm, ymm/m256
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Gt]
        public static Vector256<uint> vgt(Vector256<uint> x, Vector256<uint> y)
        {
            var mask = vbroadcast<uint>(n256, CmpMask32u);
            var mx = vxor(x,mask).AsInt32();
            var my = vxor(y,mask).AsInt32();
            return CompareGreaterThan(mx,my).AsUInt32();
        }

        /// <summary>
        ///  __m256i _mm256_cmpgt_epi64 (__m256i a, __m256i b) VPCMPGTQ ymm, ymm, ymm/m256
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Gt]
        public static Vector256<long> vgt(Vector256<long> x, Vector256<long> y)
            => CompareGreaterThan(x,y);

        /// <summary>
        ///  __m256i _mm256_cmpgt_epi64 (__m256i a, __m256i b) VPCMPGTQ ymm, ymm, ymm/m256
        /// Determines whether component values the left vector are larger than the
        /// corresponding components the right vector. When a left value is larger
        /// than a right value, the corresponding component the result vector
        /// will have all bits enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Gt]
        public static Vector256<ulong> vgt(Vector256<ulong> x, Vector256<ulong> y)
        {
            var mask = z.vbroadcast(n256,CmpMask64u);
            return v64u(CompareGreaterThan(v64i(vxor(x,mask)),v64i(vxor(y,mask))));
        }

        const byte CmpMask8u = 0x80;

        const ushort CmpMask16u = 0x8000;

        const uint CmpMask32u = 0x80000000u;

        const ulong CmpMask64u = 0x8000000000000000ul;
    }
}