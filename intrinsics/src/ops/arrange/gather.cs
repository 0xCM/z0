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
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static As;

    public enum GatherScale : byte
    {
        S1 = 1,

        S2 = 2,

        S4 = 4,

        S8 = 8,

    }

    partial class dinx
    {    
        public static string vgather_opcode<N,T>(N n, int srclen, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => $"vgather_{n}x{bitsize<T>()}x{srclen}";

        /// <summary>
        /// Loads a 128x32 vector from source data at source indices [0,63,127,255]
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The memory source</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vgather256(N128 n, ref uint src)
            => GatherVector128(ptr(ref src), VGather256x64x256Index, 4);

        /// <summary>
        /// Loads a 128x32 vector from source data at source indices [0,127,255,511]
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The memory source</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vgather512(N128 n, ref uint src)
            => GatherVector128(ptr(ref src), 
                Vector256.Create(Pow2.T00 - 1, Pow2.T07 - 1, Pow2.T08 - 1, Pow2.T09 - 1), 4);         

        /// <summary>
        /// Loads a 256x32 vector from source data at indices [0,3,7,16,31,63,127,255]
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The memory source</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vgather256(N256 n, ref uint src)
            => GatherVector256(ptr(ref src), 
                Vector256.Create(Pow2.T00 - 1, Pow2.T02 - 1, Pow2.T03 - 1, Pow2.T04 - 1, Pow2.T05 - 1, Pow2.T06 - 1, Pow2.T07 - 1, Pow2.T08 - 1), 4);

        /// <summary>
        /// Loads a 256x32 vector from source data at indices [0,7,16,31,63,127,255,511]
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The memory source</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vgather512(N256 n, ref uint src)
            => GatherVector256(ptr(ref src), VGather256x32x512Index, 4);

        /// <summary>
        /// Loads a 128x32i vector from source data at 0-based index positions determined by a an 
        /// index vector vidx with components that satisfy 0 <= vidx[i] <= 511 for i=0,1,2,3
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The memory source, covering up to 4*512 contiguous bytes </param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vgather(N128 n, ref int src, Vector128<int> index)
            => GatherVector128(ptr(ref src), index, 4);         

        /// <summary>
        /// Loads a 128x32u vector from source data at 0-based index positions determined by a an 
        /// index vector vidx with components that satisfy 0 <= vidx[i] <= 511 for i=0,1,2,3
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The memory source, covering up to 4*512 contiguous bytes </param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vgather(N128 n, ref uint src, Vector128<int> vidx)
            => GatherVector128(ptr(ref src), vidx, 4);         

        /// <summary>
        /// Loads a 128x32u vector from source data at 0-based index positions determined by a an 
        /// index vector vidx with components that satisfy 0 <= vidx[i] <= 511 for i=0,1,2,3
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The memory source, covering up to 4*512 contiguous bytes </param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vgather(N128 n, ref uint src, Vector256<long> vidx)
            => GatherVector128(ptr(ref src), vidx, 4);         

        /// <summary>
        /// Loads a 256x32i vector from source data at 0-based index positions determined by an 
        /// index vector vidx with components that satisfy 0 <= vidx[i] <= 1024 for i=0,...7
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The memory source, covering up to 4*1024 contiguous bytes </param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vgather(N256 n, ref int src, Vector256<int> index)
            => GatherVector256(ptr(ref src), index, 4);         

        /// <summary>
        /// Loads a 256x32u vector from source data at 0-based index positions determined by an 
        /// index vector vidx with components that satisfy 0 <= vidx[i] <= 1024 for i=0,...7
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The memory source, covering up to 4*1024 contiguous bytes </param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vgather(N256 n, ref uint src, Vector256<int> vidx)
            => GatherVector256(ptr(ref src), vidx, 4);         

        /// <summary>
        /// Loads a 256x64i vector from source data at 0-based index positions determined by an 
        /// index vector vidx with components that satisfy 0 <= vidx[i] <= 1024 for i=0,...3
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The memory source, covering up to 4*1024 contiguous bytes </param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vgather(N256 n, ref long src, Vector256<long> index)
            => GatherVector256(ptr(ref src), index, 8);         

        /// <summary>
        /// Loads a 256x64u vector from source data at 0-based index positions determined by an 
        /// index vector vidx with components that satisfy 0 <= vidx[i] <= 1024 for i=0,...3
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The memory source, covering up to 4*1024 contiguous bytes </param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vgather(N256 n, ref ulong src, Vector256<long> vidx)
            => GatherVector256(ptr(ref src), vidx, 8);         

        /// <summary>
        /// Loads a 256x64u vector from source data at 0-based index positions determined by an 
        /// index vector vidx with components that satisfy 0 <= vidx[i] <= 1024 for i=0,...3
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The memory source, covering up to 4*1024 contiguous bytes </param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vgather(N256 n, ref ulong src, Vector128<int> vidx)
            => GatherVector256(ptr(ref src), vidx, 8);         

        /// <summary>
        ///__m128i _mm_i32gather_epi32 (int const* base_addr, __m128i vindex, const int scale) VPGATHERDD xmm, vm32x, xmm 
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="src">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vgather(N128 n, ref int src, Vector128<int> index, GatherScale scale)
            => GatherVector128(ptr(ref src), index, (byte)scale);         

        /// <summary>
        /// __m128i _mm_i64gather_epi32 (int const* base_addr, __m128i vindex, const int scale) VPGATHERQD xmm, vm64x, xmm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="src">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vgather(N128 n, ref int src, Vector128<long> index, GatherScale scale)
            => GatherVector128(ptr(ref src), index, (byte)scale);         

        /// <summary>
        ///  __m128i _mm_i32gather_epi32 (int const* base_addr, __m128i vindex, const int scale) VPGATHERDD xmm, vm32x, xmm
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vgather(N128 n, ref uint src, Vector128<int> index, GatherScale scale)
            => GatherVector128(ptr(ref src), index, (byte)scale);         

        /// <summary>
        /// __m128i _mm_i64gather_epi32 (int const* base_addr, __m128i vindex, const int scale) VPGATHERQD xmm, vm64x, xmm
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vgather(N128 n, ref uint src, Vector128<long> index, GatherScale scale)
            => GatherVector128(ptr(ref src), index, (byte)scale);         

        /// <summary>
        /// __m128i _mm256_i64gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERQD xmm, vm64y, xmm
        /// </summary>
        /// <param name="n"></param>
        /// <param name="src"></param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vgather(N128 n, ref uint src, Vector256<long> index, GatherScale scale)
            => GatherVector128(ptr(ref src), index, (byte)scale);         

        /// <summary>
        /// __m128i _mm_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERDQ xmm, vm32x, xmm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="src">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale">1, 2, 4 or 8</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vgather(N128 n, ref ulong src, Vector128<int> index, GatherScale scale)
            => GatherVector128(ptr(ref src), index, (byte)scale);         

        /// <summary>
        /// __m128i _mm_i64gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERQQ xmm, vm64x, xmm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="src">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vgather(N128 n, ref ulong src, Vector128<long> index, GatherScale scale)
            => GatherVector128(ptr(ref src), index, (byte)scale);         

        /// <summary>
        /// __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int, scale)VPGATHERDD ymm, vm32y, ymm
        /// </summary>
        /// <param name="n"></param>
        /// <param name="src"></param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vgather(N256 n, ref int src, Vector256<int> index, GatherScale scale)
            => GatherVector256(ptr(ref src), index, (byte)scale);         

        /// <summary>
        /// __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERDD ymm, vm32y, ymm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="src">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale">1, 2, 4 or 8</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vgather(N256 n, ref uint src, Vector256<int> index, GatherScale scale)
            => GatherVector256(ptr(ref src), index, (byte)scale);         


        /// <summary>
        /// __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="src">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vgather(N256 n, ref long src, Vector256<long> index, GatherScale scale)
            => GatherVector256(ptr(ref src), index, (byte)scale);         

        /// <summary>
        ///  __m256i _mm256_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale)VPGATHERDQ ymm, vm32y, ymm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="src">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vgather(N256 n, ref long src, Vector128<int> index, GatherScale scale)
            => GatherVector256(ptr(ref src), index, (byte)scale);         

        /// <summary>
        /// __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="src">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vgather(N256 n, ref ulong src, Vector256<long> index, GatherScale scale)
            => GatherVector256(ptr(ref src), index, (byte)scale);         

        /// <summary>
        /// __m256i _mm256_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERDQ ymm, vm32y, ymm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="src">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vgather(N256 n, ref ulong src, Vector128<int> index, GatherScale scale)
            => GatherVector256(ptr(ref src), index, (byte)scale);         

        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vmgather(N128 n, Vector128<ulong> src, ref ulong mem, Vector128<long> index, Vector128<ulong> mask, GatherScale scale)
            => GatherMaskVector128(src, ptr(ref mem), index, mask, (byte)scale);

        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vmgather(N128 n, Vector128<ulong> src, ref ulong mem, Vector128<int> index, Vector128<ulong> mask, GatherScale scale)
            => GatherMaskVector128(src, ptr(ref mem), index, mask, (byte)scale);

        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vmgather(N128 n, Vector128<uint> src, ref uint mem, Vector128<long> index, Vector128<uint> mask, GatherScale scale)
            => GatherMaskVector128(src, ptr(ref mem), index, mask, (byte)scale);

        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vmgather(N128 n, Vector128<uint> src, ref uint mem, Vector256<long> index, Vector128<uint> mask, GatherScale scale)
            => GatherMaskVector128(src, ptr(ref mem), index, mask, (byte)scale);

        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vmgather(N128 n, Vector128<uint> src, ref uint mem, Vector128<int> index, Vector128<uint> mask, GatherScale scale)
            => GatherMaskVector128(src, ptr(ref mem), index, mask, (byte)scale);

        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vmgather(N256 n, Vector256<ulong> src, ref ulong mem, Vector256<long> index, Vector256<ulong> mask, GatherScale scale)
            => GatherMaskVector256(src, ptr(ref mem), index, mask, (byte)scale);

        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vmgather(N256 n, Vector256<ulong> src, ref ulong mem, Vector128<int> index, Vector256<ulong> mask, GatherScale scale)
            => GatherMaskVector256(src, ptr(ref mem), index, mask, (byte)scale);

        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vmgather(N256 n, Vector256<uint> src, ref uint mem, Vector256<int> index, Vector256<uint> mask, GatherScale scale)
            => GatherMaskVector256(src, ptr(ref mem), index, mask, (byte)scale);

       //[0, 63, 127, 255]
        static Vector256<long> VGather256x64x256Index
        {
            [MethodImpl(Inline)]
            get => ginx.vload<long>(n256, in head64i(VGather256x64x256IndexData));
        }

        //[0, 7, 15, 31, 63, 127, 255, 511]
        static Vector256<int> VGather256x32x512Index
        {
            [MethodImpl(Inline)]
            get => ginx.vload<int>(n256, in head32i(VGather256x32x512IndexData));
        }

        //[0, 63, 127, 255]
        static ReadOnlySpan<byte> VGather256x64x256IndexData => new byte[]{
            0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
            0x3f,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
            0x7f,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
            0xff,0x00,0x00,0x00,0x00,0x00,0x00,0x00
        };

 
        //[0, 7, 15, 31, 63, 127, 255, 511]
        static ReadOnlySpan<byte> VGather256x32x512IndexData => new byte[]{
            0x00,0x00,0x00,0x00,
            0x07,0x00,0x00,0x00,
            0x0f,0x00,0x00,0x00,
            0x1f,0x00,0x00,0x00,
            0x3f,0x00,0x00,0x00,
            0x7f,0x00,0x00,0x00,
            0xff,0x00,0x00,0x00,
            0xff,0x01,0x00,0x00
        };


    }
}