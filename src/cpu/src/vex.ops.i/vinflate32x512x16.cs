//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Part;
    using static memory;

    partial struct cpu
    {
        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 32x8u -> 32x16u
        /// Projects 32 unsigned 8-bit integers onto 32 unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<ushort> vinflate32x512x16u(in byte src)
            => (v16u(ConvertToVector256Int16(gptr(src))),
                v16u(ConvertToVector256Int16(gptr(src,16))));
    }
}