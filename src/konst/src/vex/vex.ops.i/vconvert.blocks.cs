//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Part;
    using static memory;

    partial struct cpu
    {
        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 4x16i -> 4x32i
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vconvert32i(in SpanBlock64<short> src, N128 w)
            => ConvertToVector128Int32(gptr(src.First));

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vconvert64i(in SpanBlock32<ushort> src, N128 w)
            => ConvertToVector128Int64(gptr(src.First));

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// 2x16u -> 2x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vconvert64u(in SpanBlock32<ushort> src, N128 w)
            => v64u(ConvertToVector128Int64(gptr(src.First)));



        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 8x16u -> 8x32i
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<int> vconvert32i(in SpanBlock128<ushort> src)
            => ConvertToVector256Int32(gptr(src.First));

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// 4x16u -> 4x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vconvert64i(in SpanBlock64<ushort> src, N256 w)
            => ConvertToVector256Int64(gptr(src.First));

        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// 4x32u -> 4x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vconvert64i(in SpanBlock128<uint> src, N256 w)
            => ConvertToVector256Int64(gptr(src.First));

        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// 4x32u -> 4x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vconvert64u(in SpanBlock128<uint> src)
            => v64u(ConvertToVector256Int64(gptr(src.First)));

        /// <summary>
        /// PMOVZXDQ xmm, m64
        /// 2x32u -> 2x64u
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vconvert(in SpanBlock64<uint> src, N128 w)
            => ConvertToVector128Int64(gptr(src.First));

        /// <summary>
        /// PMOVSXDQ xmm, m64
        /// 2x32i -> 2x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vconvert64i(in SpanBlock64<int> src, N128 w)
            => ConvertToVector128Int64(gptr(src.First));

        /// <summary>
        /// VPMOVSXDQ ymm, m128
        /// 4x32i -> 4x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vconvert64i(in SpanBlock128<int> src, N256 w)
            => ConvertToVector256Int64(gptr(src.First));

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 16x16u ->16x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<uint> vinflate512x32u(in SpanBlock256<ushort> src)
            => (v32u(ConvertToVector256Int32(gptr(src.First))),
                v32u(ConvertToVector256Int32(gptr(src.First, 8))));

        /// <summary>
        /// VPMOVSXWD ymm, m128
        /// 16x16u ->16x32u
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<int> vinflate512x32i(in SpanBlock128<short> src)
            => (ConvertToVector256Int32(gptr(src.First)),
                ConvertToVector256Int32(gptr(src.First, 8)));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 32x8u -> 32x16u
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<ushort> vconvert16u(in SpanBlock256<byte> src, N512 w)
            => (v16u(ConvertToVector256Int16(gptr(src.First))),
                v16u(ConvertToVector256Int16(gptr(src.First,16))));
    }
}