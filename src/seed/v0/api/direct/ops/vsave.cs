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
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static Konst;
    using static Typed;
    using static As;

    partial struct V0d
    {
        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<sbyte> src, ref sbyte dst)
            => Store(pref(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<byte> src, ref byte dst)
            => Store(pref(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<short> src, ref short dst)
            => Store(pref(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<ushort> src, ref ushort dst)
            => Store(pref(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<int> src, ref int dst)
            => Store(pref(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<uint> src, ref uint dst)
            => Store(pref(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<long> src, ref long dst)
            => Store(pref(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<ulong> src, ref ulong dst)
            => Store(pref(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<float> src, ref float dst)
            => Store(pref(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<double> src, ref double dst)
            => Store(pref(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<sbyte> src, ref sbyte dst)
            => Store(pref(ref dst), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<byte> src, ref byte dst)
            => Store(pref(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<short> src, ref short dst)
            => Store(pref(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<ushort> src, ref ushort dst)
            => Store(pref(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<int> src, ref int dst)
            => Store(pref(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<uint> src, ref uint dst)
            => Store(pref(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<long> src, ref long dst)
            => Store(pref(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<ulong> src, ref ulong dst)
            => Store(pref(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_ps (float * mem_addr, __m256 a) MOVUPS m256, ymm</intrinsic>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<float> src, ref float dst)
            => Store(pref(ref dst),src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_pd (double * mem_addr, __m256d a) MOVUPD m256, ymm</intrinsic>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<double> src, ref double dst)
            => Store(pref(ref dst),src); 

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<sbyte> src, ref sbyte dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<byte> src, ref byte dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<short> src, ref short dst, int offset)
            => Store(Memories.ptr(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<ushort> src, ref ushort dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<int> src, ref int dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<uint> src, ref uint dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<long> src, ref long dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<ulong> src, ref ulong dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<float> src, ref float dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector128<double> src, ref double dst, int offset)
            => Store(pref(ref dst, offset), src);

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<sbyte> src, ref sbyte dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<byte> src, ref byte dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<short> src, ref short dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<ushort> src, ref ushort dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<int> src, ref int dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<uint> src, ref uint dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<long> src, ref long dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<ulong> src, ref ulong dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_ps (float * mem_addr, __m256 a) MOVUPS m256, ymm</intrinsic>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<float> src, ref float dst, int offset)
            => Store(pref(ref dst, offset), src);            

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        ///<intrinsic>void _mm256_storeu_pd (double * mem_addr, __m256d a) MOVUPD m256, ymm</intrinsic>
        [MethodImpl(Inline), Op]
        public static unsafe void vsave(Vector256<double> src, ref double dst, int offset)
            => Store(pref(ref dst, offset), src);                 
    }
}