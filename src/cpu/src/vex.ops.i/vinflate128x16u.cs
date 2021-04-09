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
        /// PMOVZXBW xmm, m64
        /// 8x8u -> 8x16u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ushort> vinflate128x16u(in SpanBlock64<byte> src, uint offset)
            => v16u(ConvertToVector128Int16(gptr(src[offset])));

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// 8x8u -> 8x16u
        /// Projects 8 8-bit unsigned integers onto 8 16-bit unsigned integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="dst">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ushort> vmove8x16u(in byte src)
            => v16u(ConvertToVector128Int16(gptr(src)));
    }
}