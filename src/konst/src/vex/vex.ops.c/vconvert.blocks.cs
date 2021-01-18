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

    partial struct z
    {
        // ~ 8i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// PMOVSXBQ xmm, m16
        /// 2x8i -> 2x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vconvert64i(in SpanBlock16<sbyte> src, N128 w)
            => ConvertToVector128Int64(gptr(src.First));

        /// <summary>
        /// PMOVSXBD xmm, m32
        /// 4x8i -> 4x32i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vconvert32i(in SpanBlock32<sbyte> src, N128 w)
            => ConvertToVector128Int32(gptr(src.First));

        /// <summary>
        ///  VPMOVSXBQ ymm, m32
        /// 4x8i -> 4x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vconvert64i(in SpanBlock32<sbyte> src, N256 w)
            => ConvertToVector256Int64(gptr(src.First));

        /// <summary>
        /// PMOVSXBW xmm, m64
        /// 8x8i -> 8x16i
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<short> vconvert16i(in SpanBlock64<sbyte> src, N128 w)
            => ConvertToVector128Int16(gptr(src.First));

        /// <summary>
        ///  VPMOVSXBD ymm, m64
        /// 8x8i -> 8x32i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<int> vconvert32i(in SpanBlock64<sbyte> src, N256 w)
            => ConvertToVector256Int32(gptr(src.First));

        /// <summary>
        /// VPMOVSXBW ymm, m128
        /// 16x8i -> 16x16i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<short> vconvert16u(in SpanBlock128<sbyte> src, N256 w)
            => ConvertToVector256Int16(gptr(src.First));

        // ~ 8u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 2x8u -> 2x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vconvert64i(in SpanBlock16<byte> src, N128 w)
            => ConvertToVector128Int64(gptr(src.First));

        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 2x8u -> 2x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vconvert64u(in SpanBlock16<byte> src, N128 w)
            => v64u(ConvertToVector128Int64(gptr(src.First)));

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 4x8u -> 4x32i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vconvert(in SpanBlock32<byte> src, N128 w)
            => ConvertToVector128Int32(gptr(src.First));

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 4x8u -> 4x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vconvert32u(in SpanBlock32<byte> src, N128 w)
            => v32u(ConvertToVector128Int32(gptr(src.First)));

        /// <summary>
        /// VPMOVZXBQ ymm, m32
        /// 4x8u -> 4x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vconvert64u(in SpanBlock32<byte> src, N256 w)
            => v64u(ConvertToVector256Int64(gptr(src.First)));

        /// <summary>
        /// VPMOVZXBQ ymm, m32
        /// 4x8u -> 4x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vconvert64i(in SpanBlock32<byte> src, N256 w)
            => ConvertToVector256Int64(gptr(src.First));

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// 8x8u -> 8x16u
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<short> vconvert16i(in SpanBlock64<byte> src, N128 w)
            => ConvertToVector128Int16(gptr(src.First));

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// 8x8u -> 8x16u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ushort> vconvert16u(in SpanBlock64<byte> src, N128 w)
            => v16u(ConvertToVector128Int16(gptr(src.First)));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert32u(in SpanBlock64<byte> src, N256 w)
            => v32u(ConvertToVector256Int32(gptr(src.First)));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<short> vconvert16i(in SpanBlock128<byte> src, N256 w)
            => ConvertToVector256Int16(gptr(src.First));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ushort> vconvert16u(in SpanBlock128<byte> src, N256 w)
            => v16u(ConvertToVector256Int16(gptr(src.First)));

        // ~ 16i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// PMOVSXWQ xmm, m32
        /// 2x16i -> 2x64u
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vconvert64i(in SpanBlock32<short> src, N128 w)
            => ConvertToVector128Int64(gptr(src.First));

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 4x16i -> 4x32i
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vconvert32i(in SpanBlock64<short> src, N128 w)
            => ConvertToVector128Int32(gptr(src.First));

        // ~ 16u -> X
        // ~ ------------------------------------------------------------------

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
        /// VPMOVZXWQ ymm, m64
        /// 4x16u -> 4x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vconvert64u(in SpanBlock64<ushort> src, N256 w)
            => v64u(ConvertToVector256Int64(gptr(src.First)));

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 4x16u -> 4x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vconvert32u(in SpanBlock64<ushort> src, N128 w)
            => v32u(ConvertToVector128Int32(gptr(src.First)));

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 8x16u -> 8x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert32u(in SpanBlock128<ushort> src)
            => v32u(ConvertToVector256Int32(gptr(src.First)));

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

        // ~ 32u -> X
        // ~ ------------------------------------------------------------------

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

        // ~ 32i -> X
        // ~ ------------------------------------------------------------------

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

        // ~ X -> 512
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 16x16u ->16x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<uint> vconvert32u(in SpanBlock256<ushort> src, N512 w)
            => (v32u(ConvertToVector256Int32(gptr(src.First))),
                v32u(ConvertToVector256Int32(gptr(src.First, 8))));

        /// <summary>
        /// VPMOVSXWD ymm, m128
        /// 16x16u ->16x32u
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<int> vconvert32i(in SpanBlock128<short> src, N512 w)
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

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// 8x16u -> 8x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower target</param>
        /// <param name="hi">The upper target</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<ulong> vconvert64u(in SpanBlock128<ushort> src, N512 w)
            => (v64u(ConvertToVector256Int64(gptr(src.First))),
                v64u(ConvertToVector256Int64(gptr(src.First,4))));

        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// 8x32u -> 8x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower target</param>
        /// <param name="hi">The upper target</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<ulong> vconvert64u(in SpanBlock256<uint> src, N512 w)
            => (v64u(ConvertToVector256Int64(gptr(src.First))),
                v64u(ConvertToVector256Int64(gptr(src.First,4))));
    }
}