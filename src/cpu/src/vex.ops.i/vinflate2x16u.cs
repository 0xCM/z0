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
    using static Root;
    using static core;

    partial struct cpu
    {
        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// 2x16u -> 2x64u
        /// Projects 2 unsigned 16-bit integers onto two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op(inflate)]
        public static unsafe Vector128<ulong> vinflate2x16u(in ushort src, out Vector128<ulong> dst)
            => dst = v64u(ConvertToVector128Int64(gptr(src)));
    }
}