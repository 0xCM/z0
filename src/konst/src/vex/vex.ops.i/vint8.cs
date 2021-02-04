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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static Part;

    partial struct cpu
    {
        /// <summary>
        /// src[0..7] -> r/m8[0..31]
        /// int _mm_cvtsi128_si32 (__m128i a) MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <remarks>
        /// vmovupd xmm0,[rcx] |> vmovd eax,xmm0 |> movzx rax,al
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static sbyte vint8i(Vector128<sbyte> src)
            => (sbyte)vint32i(v32i(src));

        /// <summary>
        /// src[0..7] -> r/m8[0..31]
        /// int _mm_cvtsi128_si32 (__m128i a) MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <remarks>
        /// vmovupd xmm0,[rcx] |> vmovd eax,xmm0 |> movzx eax,al
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static byte vint8u(Vector128<byte> src)
            => (byte)vint32u(v32u(src));
    }
}