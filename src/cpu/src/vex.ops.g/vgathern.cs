//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Root;

    partial struct cpu
    {
        /// <summary>
        /// __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERDD ymm, vm32y, ymm
        /// Loads 8 unsigned 32-bit integers from base-relative locations, unscaled
        /// </summary>
        /// <param name="base">The base address from which the load is relative</param>
        /// <param name="vidx">The base-relative addresses of the 8 values to load</param>
        /// <param name="scale">The scale selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vgather(MemoryAddress @base, Vector256<uint> vidx)
            => GatherVector256(@base.Pointer<uint>(), v32i(vidx), 1);

        /// <summary>
        /// __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERDD ymm, vm32y, ymm
        /// Loads 8 unsigned 32-bit integers from base-relative locations with a scale factor of 2
        /// </summary>
        /// <param name="base">The base address from which the load is relative</param>
        /// <param name="vidx">The base-relative addresses of the 8 values to load</param>
        /// <param name="scale">The scale selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vgather(MemoryAddress @base, Vector256<uint> vidx, N2 scale)
            => GatherVector256(@base.Pointer<uint>(), v32i(vidx), 2);

        /// <summary>
        /// __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERDD ymm, vm32y, ymm
        /// Loads 8 unsigned 32-bit integers from base-relative locations with a scale factor of 4
        /// </summary>
        /// <param name="base">The base address from which the load is relative</param>
        /// <param name="vidx">The base-relative addresses of the 8 values to load</param>
        /// <param name="scale">The scale selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vgather(MemoryAddress @base, Vector256<uint> vidx, N4 scale)
            => GatherVector256(@base.Pointer<uint>(), v32i(vidx), 4);

        /// <summary>
        /// __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERDD ymm, vm32y, ymm
        /// Loads 8 unsigned 32-bit integers from base-relative locations with a scale factor of 8
        /// </summary>
        /// <param name="base">The base address from which the load is relative</param>
        /// <param name="vidx">The base-relative addresses of the 8 values to load</param>
        /// <param name="scale">The scale selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vgather(MemoryAddress @base, Vector256<uint> vidx, N8 scale)
            => GatherVector256(@base.Pointer<uint>(), v32i(vidx), 8);
    }
}