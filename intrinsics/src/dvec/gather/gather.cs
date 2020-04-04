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
    
    using static VCore;
    using static Core;
    using static AsIn;

    partial class dvec
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
            => GatherVector128(constptr(in src), index, 4);         

        /// <summary>
        /// __m128i _mm256_i64gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERQD xmm, vm64y, xmm
        /// Loads a 128x32u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vgather(N128 w, in uint src, Vector256<ulong> vidx)
            => GatherVector128(constptr(in src), v64i(vidx), 4);         

        /// <summary>
        /// __m128i _mm_i64gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERQQ xmm, vm64x, xmm
        /// Loads a 128x64u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vgather(N128 w, in long src, Vector128<long> vidx)
            => GatherVector128(constptr(in src), vidx, 8);         

        /// <summary>
        /// __m128i _mm_i64gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERQQ xmm, vm64x, xmm
        /// Loads a 128x32u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vgather(N128 w, in ulong src, Vector128<ulong> vidx)
            => GatherVector128(constptr(in src), v64i(vidx), 8);         

        /// <summary>
        /// __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERDD ymm, vm32y, ymm
        /// Loads a 256x32i vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<int> vgather(N256 w, in int src, Vector256<int> index)
            => GatherVector256(constptr(in src), index, 4);         

        /// <summary>
        /// __m128i _mm_i32gather_epi32(int const* base_addr, __m128i vindex, const int scale) VPGATHERDD xmm, vm32x, xmm
        /// Loads a 128x32u vector from from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vgather(N128 w, in uint src, Vector128<uint> vidx)
            => GatherVector128(constptr(in src), v32i(vidx), 4);         

        /// <summary>
        /// __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int scale) VPGATHERDD ymm, vm32y, ymm
        /// Loads a 256x32u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vgather(N256 w, in uint src, Vector256<uint> vidx)
            => GatherVector256(constptr(in src), v32i(vidx), 4);         

        /// <summary>
        /// Loads a 128x16u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ushort> vgather(N128 w, in ushort src, Vector128<ushort> vidx)
            => dvec.vcompact(GatherVector256(constptr(in uint32(in src)), v32i(dvec.vinflate(vidx, n256, z32)),2),n128, z16);

        /// <summary>
        /// Loads a 128x16i vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<short> vgather(N128 w, in short src, Vector128<short> vidx)
            => v16i(dvec.vcompact(GatherVector256(constptr(in uint32(in src)), v32i(dvec.vinflate(v16u(vidx), n256, z32)),2),n128, z16));

        /// <summary>
        /// Loads a 128x8u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<sbyte> vgather(N128 w, in sbyte src, Vector128<sbyte> vidx)
        {
            (var v0, var v1) = dvec.vinflate(v8u(vidx), n512, z32);
            var x0 = GatherVector256(constptr(in uint32(in src)), v32i(v0),1);
            var x1 = GatherVector256(constptr(in uint32(in src)), v32i(v1),1);
            return v8i(dvec.vcompact(x0,x1,n128, z8));
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
            (var v0, var v1) = dvec.vinflate(vidx, n512, z32);
            var x0 = GatherVector256(constptr(in uint32(in src)), v32i(v0),1);
            var x1 = GatherVector256(constptr(in uint32(in src)), v32i(v1),1);
            return dvec.vcompact(x0,x1,n128, z8);
        }


        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vgather(N256 w, in sbyte src, Vector256<sbyte> vidx)        
            => VCoreD.vconcat(
                    vgather(n128, in src, dvec.vlo(vidx)), 
                    vgather(n128, in src, dvec.vhi(vidx)));

        [MethodImpl(Inline), Op]
        public static Vector256<byte> vgather(N256 w, in byte src, Vector256<byte> vidx)        
            => VCoreD.vconcat(
                    vgather(n128, in src, dvec.vlo(vidx)), 
                    vgather(n128, in src, dvec.vhi(vidx)));


        [MethodImpl(Inline), Op]
        public static Vector256<short> vgather(N256 w, in short src, Vector256<short> vidx)        
            => VCoreD.vconcat(
                    vgather(n128, in src, dvec.vlo(vidx)), 
                    vgather(n128, in src, dvec.vhi(vidx)));

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vgather(N256 w, in ushort src, Vector256<ushort> vidx)        
            => VCoreD.vconcat(
                    vgather(n128, in src, dvec.vlo(vidx)), 
                    vgather(n128, in src, dvec.vhi(vidx)));

        /// <summary>
        /// __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
        /// Loads a 256x64i vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vgather(N256 w, in long src, Vector256<long> index)
            => GatherVector256(constptr(in src), index, 8);         

        /// <summary>
        /// __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
        /// Loads a 256x64u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory reference</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vgather(N256 w, in ulong src, Vector256<ulong> vidx)
            => GatherVector256(constptr(in src), v64i(vidx), 8);         

        /// <summary>
        /// __m256i _mm256_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERDQ ymm, vm32y, ymm
        /// Loads a 256x64u vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vgather(N256 w, in ulong src, Vector128<uint> vidx)
            => GatherVector256(constptr(in src), v32i(vidx), 8);         

        /// <summary>
        ///  __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
        /// Loads a 256x64i vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="scale">The amount by which to scale each index component value</param>
        [MethodImpl(Inline), Op]
        static unsafe Vector256<long> vgather(N256 w, in long src, Vector256<long> vidx, byte scale)
            => GatherVector256(constptr(in src), vidx, scale);         

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
        static unsafe Vector256<ulong> vgather(N256 w, in ulong src, Vector256<long> vidx, byte scale)
            => GatherVector256(constptr(in src), vidx, scale);         

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
        static unsafe Vector256<ulong> vgather(N256 w, in ulong src, Vector128<int> vidx, byte scale)
            => GatherVector256(constptr(in src), vidx, scale);          

        [MethodImpl(Inline), Op]
        static unsafe Vector256<uint> vgather(N256 w, in ushort src, Vector256<uint> vidx)
            => GatherVector256(constptr(in uint32(in src)), v32i(vidx), 2);
    }
}