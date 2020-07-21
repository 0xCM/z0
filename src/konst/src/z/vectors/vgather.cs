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
        ///  __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
        /// Loads a 256x64i vector from index-identified source cells
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory source</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="scale">The amount by which to scale each index component value</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vgather(N256 w, in long src, Vector256<long> vidx, byte scale)
            => GatherVector256(gptr(src), vidx, scale);         

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
        public static unsafe Vector256<ulong> vgather(N256 w, in ulong src, Vector256<long> vidx, byte scale)
            => GatherVector256(gptr(src), vidx, scale);         

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
        public static unsafe Vector256<ulong> vgather(N256 w, in ulong src, Vector128<int> vidx, byte scale)
            => GatherVector256(gptr(src), vidx, scale);          

        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vgather(N256 w, in ushort src, Vector256<uint> vidx)
            => GatherVector256(p32u(src), v32i(vidx), 2);
    }
}