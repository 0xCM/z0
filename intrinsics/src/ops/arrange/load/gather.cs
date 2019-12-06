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
        /// Loads a 128x32u vector from source data at 0-based index positions determined by a an 
        /// index vector vidx with components that satisfy 0 <= vidx[i] <= 511 for i=0,1
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The memory source, covering up to 4*512 contiguous bytes </param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vgather(N128 n, ref long src, Vector128<long> vidx)
            => GatherVector128(ptr(ref src), vidx, 8);         

        /// <summary>
        /// Loads a 128x32u vector from source data at 0-based index positions determined by a an 
        /// index vector vidx with components that satisfy 0 <= vidx[i] <= 511 for i=0,1
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="src">The memory source, covering up to 4*512 contiguous bytes </param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vgather(N128 n, ref ulong src, Vector128<long> vidx)
            => GatherVector128(ptr(ref src), vidx, 8);         

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
        /// __m128i _mm_mask_i32gather_epi32 (__m128i src, int const* base_addr, __m128i vindex, __m128i mask, const int scale) VPGATHERDD xmm, vm32x, xmm
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for taget component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        /// <remarks>Elements are copied from the source vector when the highest bit of the corresponding element in the mask vector is not set
        /// If, for example, all hi bits in the mask vector are set then the corresponding target element is loaded from the index-identified cell
        /// and this operation reduces to the coresponding maskless gather function
        /// </remarks>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vmgather(N128 n, Vector128<uint> vsrc, ref uint msrc, Vector128<int> vidx, Vector128<uint> mask)
            => GatherMaskVector128(vsrc, ptr(ref msrc), vidx, mask, 4);

        /// <summary>
        /// __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
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
        /// __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
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
        /// __m256i _mm256_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERDQ ymm, vm32y, ymm
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
        ///  __m256i _mm256_mask_i32gather_epi64 (__m256i src, __int64 const* base_addr, __m128i vindex, __m256i mask, const int scale) VPGATHERDQ ymm, vm32y, ymm
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for taget component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vmgather(N256 n, Vector256<ulong> vsrc, ref ulong msrc, Vector128<int> vidx, Vector256<ulong> mask)
            => GatherMaskVector256(vsrc, ptr(ref msrc), vidx, mask, 8);

        /// <summary>
        /// __m128i _mm_mask_i64gather_epi64 (__m128i src, __int64 const* base_addr, __m128i vindex, __m128i mask, const int scale) VPGATHERQQ xmm, vm64x, xmm
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="vsrc"></param>
        /// <param name="msrc"></param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vmgather(N128 n, Vector128<ulong> vsrc, ref ulong msrc, Vector128<long> vidx, Vector128<ulong> mask)
            => GatherMaskVector128(vsrc, ptr(ref msrc), vidx, mask, 8);

        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vmgather(N128 n, Vector128<ulong> vsrc, ref ulong msrc, Vector128<int> vidx, Vector128<ulong> mask)
            => GatherMaskVector128(vsrc, ptr(ref msrc), vidx, mask, 8);

        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vmgather(N128 n, Vector128<uint> vsrc, ref uint msrc, Vector128<long> vidx, Vector128<uint> mask)
            => GatherMaskVector128(vsrc, ptr(ref msrc), vidx, mask, 4);

        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vmgather(N128 n, Vector128<uint> vsrc, ref uint msrc, Vector256<long> vidx, Vector128<uint> mask)
            => GatherMaskVector128(vsrc, ptr(ref msrc), vidx, mask, 4);


        /// <summary>
        /// __m256i _mm256_mask_i64gather_epi64 (__m256i src, __int64 const* base_addr, __m256i vindex, __m256i mask, const int scale) VPGATHERQQ ymm, vm32y, ymm
        /// </summary>
        /// <param name="n"></param>
        /// <param name="vsrc"></param>
        /// <param name="msrc"></param>
        /// <param name="vidx"></param>
        /// <param name="mask"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vmgather(N256 n, Vector256<ulong> vsrc, ref ulong msrc, Vector256<long> vidx, Vector256<ulong> mask)
            => GatherMaskVector256(vsrc, ptr(ref msrc), vidx, mask, 8);


        /// <summary>
        ///   __m256i _mm256_mask_i32gather_epi32 (__m256i src, int const* base_addr, __m256i vindex, __m256i mask, const int scale) VPGATHERDD ymm, vm32y, ymm
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="vsrc"></param>
        /// <param name="msrc"></param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask"></param>
        /// <returns></returns>        
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vmgather(N256 n, Vector256<uint> vsrc, ref uint msrc, Vector256<int> vidx, Vector256<uint> mask)
            => GatherMaskVector256(vsrc, ptr(ref msrc), vidx, mask, 4);

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

    public enum GatherScale : byte
    {
        S1 = 1,

        S2 = 2,

        S4 = 4,

        S8 = 8,

    }


}