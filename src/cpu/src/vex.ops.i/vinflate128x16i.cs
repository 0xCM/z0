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
    using static Part;
    using static memory;

    partial struct cpu
    {
        /// <summary>
        /// PMOVSXBW xmm, m64
        /// 8x8i -> 8x16i
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<short> vinflate128x16i(in SpanBlock64<sbyte> src, uint offset)
            => ConvertToVector128Int16(gptr(src[offset]));

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// 8x8u -> 8x16u
        /// </summary>
        /// <param name="src">The memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<short> vinflate128x16i(in SpanBlock64<byte> src, uint offset)
            => ConvertToVector128Int16(gptr(src[offset]));

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// 8x8u -> 8x16u
        /// Projects 8 8-bit unsigned integers onto 8 signed 16-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<short> vmove8x16i(in byte src)
            => ConvertToVector128Int16(gptr(src));
    }
}