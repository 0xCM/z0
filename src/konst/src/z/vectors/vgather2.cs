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
 
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;

    partial struct z
    {                            
        /// <summary>
        ///  __m128i _mm_i32gather_epi32 (int const* base_addr, __m128i vindex, const int scale) VPGATHERDD xmm, vm32x, xmm
        /// Loads a 128x32i vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vgather(N128 w, in int src, Vector128<int> index)
            => GatherVector128(z.gptr(src), index, 4);         

        /// <summary>
        /// __m128i _mm256_i64gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERQD xmm, vm64y, xmm
        /// Loads a 128x32u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vgather(N128 w, in uint src, Vector256<ulong> vidx)
            => GatherVector128(z.gptr(src), z.v64i(vidx), 4);         

        /// <summary>
        /// __m128i _mm_i64gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERQQ xmm, vm64x, xmm
        /// Loads a 128x64u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vgather(N128 w, in long src, Vector128<long> vidx)
            => GatherVector128(z.gptr(src), vidx, 8);         

        /// <summary>
        /// __m128i _mm_i64gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERQQ xmm, vm64x, xmm
        /// Loads a 128x32u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vgather(N128 w, in ulong src, Vector128<ulong> vidx)
            => GatherVector128(z.gptr(src), z.v64i(vidx), 8);         

        /// <summary>
        /// __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERDD ymm, vm32y, ymm
        /// Loads a 256x32i vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<int> vgather(N256 w, in int src, Vector256<int> index)
            => GatherVector256(z.gptr(src), index, 4);         

        /// <summary>
        /// __m128i _mm_i32gather_epi32(int const* base_addr, __m128i vindex, const int scale) VPGATHERDD xmm, vm32x, xmm
        /// Loads a 128x32u vector from from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vgather(N128 w, in uint src, Vector128<uint> vidx)
            => GatherVector128(z.gptr(src), z.v32i(vidx), 4);         

        /// <summary>
        /// __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERDD ymm, vm32y, ymm
        /// Loads a 256x32u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vgather(N256 w, in uint src, Vector256<uint> vidx)
            => GatherVector256(z.gptr(src), z.v32i(vidx), 4);         

        /// <summary>
        /// __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
        /// Loads a 256x64i vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vgather(N256 w, in long src, Vector256<long> index)
            => GatherVector256(z.gptr(src), index, 8);         

        /// <summary>
        /// __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
        /// Loads a 256x64u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory reference</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vgather(N256 w, in ulong src, Vector256<ulong> vidx)
            => GatherVector256(z.gptr(src), z.v64i(vidx), 8);         

        /// <summary>
        /// __m256i _mm256_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERDQ ymm, vm32y, ymm
        /// Loads a 256x64u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vgather(N256 w, in ulong src, Vector128<uint> vidx)
            => GatherVector256(z.gptr(src), z.v32i(vidx), 8);

        // /// <summary>
        // /// Loads a 128x16u vector from index-identified source cells
        // /// </summary>
        // /// <param name="w">The target vector width</param>
        // /// <param name="src">The memory source</param>
        // /// <param name="vidx">The index vector</param>
        // [MethodImpl(Inline), Op]
        // public static unsafe Vector128<ushort> vgather(N128 w, in ushort src, Vector128<ushort> vidx)
        //     => dvec.vcompact(GatherVector256(z.p32u(src), z.v32i(dvec.vinflate(vidx, n256, z32)), 2), n128, z16);

        // /// <summary>
        // /// Loads a 128x16i vector from index-identified source cells
        // /// </summary>
        // /// <param name="w">The target vector width</param>
        // /// <param name="src">The memory source</param>
        // /// <param name="vidx">The index vector</param>
        // [MethodImpl(Inline), Op]
        // public static unsafe Vector128<short> vgather(N128 w, in short src, Vector128<short> vidx)
        //     => v16i(dvec.vcompact(GatherVector256(z.p32u(src), z.v32i(dvec.vinflate(z.v16u(vidx), n256, z32)),2),n128, z16));

        // /// <summary>
        // /// Loads a 128x8u vector from index-identified source cells
        // /// </summary>
        // /// <param name="w">The target vector width</param>
        // /// <param name="src">The memory source</param>
        // /// <param name="vidx">The index vector</param>
        // [MethodImpl(Inline), Op]
        // public static unsafe Vector128<sbyte> vgather(N128 w, in sbyte src, Vector128<sbyte> vidx)
        // {
        //     (var v0, var v1) = dvec.vinflate(v8u(vidx), n512, z32);
        //     var x0 = GatherVector256(z.p32u(src), z.v32i(v0),1);
        //     var x1 = GatherVector256(z.p32u(src), z.v32i(v1),1);
        //     return v8i(dvec.vcompact(x0,x1,n128, z8));
        // }

        // /// <summary>
        // /// Loads a 128x8u vector from index-identified source cells
        // /// </summary>
        // /// <param name="w">The target vector width</param>
        // /// <param name="src">The memory source</param>
        // /// <param name="vidx">The index vector</param>
        // [MethodImpl(Inline), Op]
        // public static unsafe Vector128<byte> vgather(N128 w, in byte src, Vector128<byte> vidx)
        // {
        //     (var v0, var v1) = dvec.vinflate(vidx, n512, z32);
        //     var x0 = GatherVector256(z.p32u(src), z.v32i(v0),1);
        //     var x1 = GatherVector256(z.p32u(src), z.v32i(v1),1);
        //     return dvec.vcompact(x0,x1,n128, z8);
        // }

        // [MethodImpl(Inline), Op]
        // public static Vector256<sbyte> vgather(N256 w, in sbyte src, Vector256<sbyte> vidx)        
        //     => V0d.vconcat(vgather(n128, src, V0d.vlo(vidx)), vgather(n128, src, V0d.vhi(vidx)));

        // [MethodImpl(Inline), Op]
        // public static Vector256<byte> vgather(N256 w, in byte src, Vector256<byte> vidx)        
        //     => V0d.vconcat(vgather(n128, src, V0d.vlo(vidx)), vgather(n128, src, V0d.vhi(vidx)));

        // [MethodImpl(Inline), Op]
        // public static Vector256<short> vgather(N256 w, in short src, Vector256<short> vidx)        
        //     => V0d.vconcat(vgather(n128, src, V0d.vlo(vidx)), vgather(n128, src, V0d.vhi(vidx)));

        // [MethodImpl(Inline), Op]
        // public static Vector256<ushort> vgather(N256 w, in ushort src, Vector256<ushort> vidx)        
        //     => V0d.vconcat(vgather(n128, src, V0d.vlo(vidx)), vgather(n128, src, V0d.vhi(vidx)));
    }
}