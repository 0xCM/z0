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
        /// PMOVSXBQ xmm, m16
        /// 2x8i -> 2x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vinflate128x64i(in SpanBlock16<sbyte> src, uint offset)
            => ConvertToVector128Int64(gptr(src[offset]));

        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 2x8u -> 2x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vinflate128x64i(in SpanBlock16<byte> src, uint offset)
            => ConvertToVector128Int64(gptr(src[offset]));

        /// <summary>
        /// PMOVSXWQ xmm, m32
        /// 2x16i -> 2x64u
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vinflate128x64i(in SpanBlock32<short> src, uint offset)
            => ConvertToVector128Int64(gptr(src[offset]));

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vinflate128x64i(in SpanBlock32<ushort> src, uint offset)
            => ConvertToVector128Int64(gptr(src.First));

        /// <summary>
        /// PMOVSXWQ xmm, m32
        /// 2x16i -> 2x64u
        /// Projects 2 16-bit signed integers onto 2 64-bit signed integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vmove2x64i(in short src)
            => ConvertToVector128Int64(gptr(src));

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// Projects 2 unsigned 16-bit integers onto 2 signed 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vmove2x64i(in ushort src)
            => ConvertToVector128Int64(gptr(src));

        /// <summary>
        /// PMOVSXDQ xmm, m64
        /// 2x32i -> 2x64i
        /// Projects 2 signed 32-bit integers onto 2 signed 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vmove2x64i(in int src)
            => ConvertToVector128Int64(gptr(src));

        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 2x8u -> 2x64i
        /// Projects two unsigned 8-bit integers onto 2 signed 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vmove2x64i(in byte src)
            => ConvertToVector128Int64(gptr(src));
    }
}