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
    using static Part;
    using static memory;

    partial struct cpu
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
            => GatherVector128(gptr(src), index, 4);

        /// <summary>
        /// __m128i _mm256_i64gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERQD xmm, vm64y, xmm
        /// Loads a 128x32u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vgather(N128 w, in uint src, Vector256<ulong> vidx)
            => GatherVector128(gptr(src), v64i(vidx), 4);

        /// <summary>
        /// __m128i _mm_i64gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERQQ xmm, vm64x, xmm
        /// Loads a 128x64u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vgather(N128 w, in long src, Vector128<long> vidx)
            => GatherVector128(gptr(src), vidx, 8);

        /// <summary>
        /// __m128i _mm_i64gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERQQ xmm, vm64x, xmm
        /// Loads a 128x32u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vgather(N128 w, in ulong src, Vector128<ulong> vidx)
            => GatherVector128(gptr(src), v64i(vidx), 8);

        /// <summary>
        /// __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERDD ymm, vm32y, ymm
        /// Loads a 256x32i vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<int> vgather(N256 w, in int src, Vector256<int> index)
            => GatherVector256(gptr(src), index, 4);

        /// <summary>
        /// __m128i _mm_i32gather_epi32(int const* base_addr, __m128i vindex, const int scale) VPGATHERDD xmm, vm32x, xmm
        /// Loads a 128x32u vector from from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vgather(N128 w, in uint src, Vector128<uint> vidx)
            => GatherVector128(gptr(src), v32i(vidx), 4);

        /// <summary>
        /// __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERDD ymm, vm32y, ymm
        /// Loads a 256x32u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vgather(N256 w, in uint src, Vector256<uint> vidx)
            => GatherVector256(gptr(src), v32i(vidx), 4);

        /// <summary>
        /// __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
        /// Loads a 256x64i vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vgather(N256 w, in long src, Vector256<long> index)
            => GatherVector256(gptr(src), index, 8);

        /// <summary>
        /// __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
        /// Loads a 256x64u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory reference</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vgather(N256 w, in ulong src, Vector256<ulong> vidx)
            => GatherVector256(gptr(src), v64i(vidx), 8);

        /// <summary>
        /// __m256i _mm256_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERDQ ymm, vm32y, ymm
        /// Loads a 256x64u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vgather(N256 w, in ulong src, Vector128<uint> vidx)
            => GatherVector256(gptr(src), v32i(vidx), 8);

        /// <summary>
        /// Loads a 128x16u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ushort> vgather(N128 w, in ushort src, Vector128<ushort> vidx)
            => vpack128x16u(GatherVector256(p32u(src), v32i(vinflate256x32u(vidx)), 2));

        /// <summary>
        /// Loads a 128x16i vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<short> vgather(N128 w, in short src, Vector128<short> vidx)
            => v16i(vpack128x16u(GatherVector256(p32u(src), v32i(vinflate256x32u(v16u(vidx))),2)));

        /// <summary>
        /// Loads a 128x8u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<sbyte> vgather(N128 w, in sbyte src, Vector128<sbyte> vidx)
        {
            (var v0, var v1) = vinflate512x32u(v8u(vidx));
            var x0 = GatherVector256(p32u(src), v32i(v0),1);
            var x1 = GatherVector256(p32u(src), v32i(v1),1);
            return v8i(vpack128x8u(x0, x1));
        }

        /// <summary>
        /// Loads a 128x8u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<byte> vgather(N128 w, in byte src, Vector128<byte> vidx)
        {
            (var v0, var v1) = vinflate512x32u(vidx);
            var x0 = GatherVector256(p32u(src), v32i(v0), 1);
            var x1 = GatherVector256(p32u(src), v32i(v1), 1);
            return vpack128x8u(x0, x1);
        }

        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vgather(N256 w, in sbyte src, Vector256<sbyte> vidx)
            => vconcat(vgather(n128, src, vlo(vidx)), vgather(n128, src, vhi(vidx)));

        [MethodImpl(Inline), Op]
        public static Vector256<byte> vgather(N256 w, in byte src, Vector256<byte> vidx)
            => vconcat(vgather(n128, src, vlo(vidx)), vgather(n128, src, vhi(vidx)));

        [MethodImpl(Inline), Op]
        public static Vector256<short> vgather(N256 w, in short src, Vector256<short> vidx)
            => vconcat(vgather(n128, src, vlo(vidx)), vgather(n128, src, vhi(vidx)));

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vgather(N256 w, in ushort src, Vector256<ushort> vidx)
            => vconcat(vgather(n128, src, vlo(vidx)), vgather(n128, src, vhi(vidx)));

        /// <summary>
        ///  __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
        /// Loads a 256x64i vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="scale">The amount by which to scale each index component value</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vgather(in long src, Vector256<long> vidx, [Imm] ScaleFactor scale)
            => GatherVector256(gptr(src), vidx, (byte)scale);

        /// <summary>
        /// __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
        /// Loads a 256x64u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="scale">The amount by which to scale each index component value</param>
        /// <remarks>Intel's description:
        /// Gather 64-bit integers from memory using 64-bit indices. 64-bit elements are loaded from addresses
        /// starting at base_addr and offset by each 64-bit element in vindex (each index is scaled by the factor in scale).
        /// Gathered elements are merged into dst. scale should be 1, 2, 4 or 8.
        /// FOR j := 0 to 3, i := j*64, m := j*64
        ///	    dst[i+63:i] := MEM[base_addr + SignExtend(vindex[m+63:m])*scale]
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vgather(in ulong src, Vector256<long> vidx, [Imm] ScaleFactor scale)
            => GatherVector256(gptr(src), vidx, (byte)scale);

        /// <summary>
        /// __m256i _mm256_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERDQ ymm, vm32y, ymm
        /// Loads a 256x64u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="scale">The amount by which to scale each index component value</param>
        /// <remarks>Intel's description:
        /// Gather 64-bit integers from memory using 32-bit indices. 64-bit elements are loaded from addresses
        /// starting at base_addr and offset by each 32-bit element in vindex (each index is scaled by the factor in scale).
        /// Gathered elements are merged into dst. scale should be 1, 2, 4 or 8.
        /// FOR j := 0 to 3, i := j*64, m := j*32
	    ///     dst[i+63:i] := MEM[base_addr + SignExtend(vindex[m+31:m])*scale]
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vgather(in ulong src, Vector128<int> vidx, [Imm] ScaleFactor scale)
            => GatherVector256(gptr(src), vidx, (byte)scale);

        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vgather(in ushort src, Vector256<uint> vidx)
            => GatherVector256(p32u(src), v32i(vidx), 2);

        /// <summary>
        /// __m128i _mm_mask_i32gather_epi32 (__m128i src, int const* base_addr, __m128i vindex, __m128i mask, const int scale) VPGATHERDD xmm, vm32x, xmm
        /// </summary>
        /// <param name="msrc">The memory-based source for target component data as controlled by the mask vector</param>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        /// <remarks>Elements are copied from the source vector when the highest bit of the corresponding element in the mask vector is not set
        /// If, for example, all hi bits in the mask vector are set then the corresponding target element is loaded from the index-identified cell
        /// and this operation reduces to the coresponding maskless gather function
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vgather(MemoryAddress msrc, Vector128<uint> vsrc, Vector128<int> vidx, Vector128<uint> mask)
            => GatherMaskVector128(vsrc, msrc.Pointer<uint>(), vidx, mask, 4);

        /// <summary>
        /// __m128i _mm_mask_i64gather_epi64 (__m128i src, __int64 const* base_addr, __m128i vindex, __m128i mask, const int scale) VPGATHERQQ xmm, vm64x, xmm
        /// </summary>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for target component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vgather(Vector128<ulong> vsrc, MemoryAddress msrc, Vector128<long> vidx, Vector128<ulong> mask)
            => GatherMaskVector128(vsrc, msrc.Pointer<ulong>(), vidx, mask, 8);

        /// <summary>
        /// __m128i _mm_mask_i32gather_epi64 (__m128i src, __int64 const* base_addr, __m128i vindex, __m128i mask, const int scale) VPGATHERDQ xmm, vm32x, xmm
        /// </summary>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for target component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vgather(Vector128<ulong> vsrc, MemoryAddress msrc, Vector128<int> vidx, Vector128<ulong> mask)
            => GatherMaskVector128(vsrc, msrc.Pointer<ulong>(), vidx, mask, 8);

        /// <summary>
        /// __m128i _mm_mask_i64gather_epi32 (__m128i src, int const* base_addr, __m128i vindex, __m128i mask, const int scale) VPGATHERQD xmm, vm64x, xmm
        /// </summary>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for target component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vgather(Vector128<uint> vsrc, MemoryAddress msrc, Vector128<long> vidx, Vector128<uint> mask)
            => GatherMaskVector128(vsrc, msrc.Pointer<uint>(), vidx, mask, 4);

        /// <summary>
        /// __m128i _mm256_mask_i64gather_epi32 (__m128i src, int const* base_addr, __m256i vindex, __m128i mask, const int scale) VPGATHERQD xmm, vm32y, xmm
        /// </summary>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for target component data as controlled by the mask vector</param>
        /// <param name="mSrc">The memory-based source for target component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vgather(Vector128<uint> vsrc,  MemoryAddress msrc, Vector256<long> vidx, Vector128<uint> mask)
            => GatherMaskVector128(vsrc, msrc.Pointer<uint>(), vidx, mask, 4);

        /// <summary>
        ///   __m256i _mm256_mask_i32gather_epi32 (__m256i src, int const* base_addr, __m256i vindex, __m256i mask, const int scale) VPGATHERDD ymm, vm32y, ymm
        /// </summary>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for target component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vgather(Vector256<uint> vsrc, MemoryAddress msrc, Vector256<int> vidx, Vector256<uint> mask)
            => GatherMaskVector256(vsrc, msrc.Pointer<uint>(), vidx, mask, 4);

        /// <summary>
        /// __m256i _mm256_mask_i64gather_epi64 (__m256i src, __int64 const* base_addr, __m256i vindex, __m256i mask, const int scale) VPGATHERQQ ymm, vm32y, ymm
        /// </summary>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for target component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vgather(Vector256<ulong> vsrc, MemoryAddress msrc, Vector256<long> vidx, Vector256<ulong> mask)
            => GatherMaskVector256(vsrc, msrc.Pointer<ulong>(), vidx, mask, 8);

        /// <summary>
        ///  __m256i _mm256_mask_i32gather_epi64 (__m256i src, __int64 const* base_addr, __m128i vindex, __m256i mask, const int scale) VPGATHERDQ ymm, vm32y, ymm
        /// </summary>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for target component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vgather(Vector256<ulong> vsrc, MemoryAddress msrc, Vector128<int> vidx, Vector256<ulong> mask)
            => GatherMaskVector256(vsrc, msrc.Pointer<ulong>(), vidx, mask, 8);
    }
}