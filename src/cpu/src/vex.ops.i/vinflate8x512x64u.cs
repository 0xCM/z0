//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Root;
    using static core;

    partial struct cpu
    {
        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// 8x32u -> 8x64u
        /// Projects 8 unsigned 32-bit integers onto 8 unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower target</param>
        /// <param name="hi">The upper target</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<ulong> vinflate8x512x64u(in uint src)
            => (v64u(ConvertToVector256Int64(gptr(src))),
                v64u(ConvertToVector256Int64(gptr(src,4))));

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// 8x16u -> 8x64u
        /// Projects 8 unsigned 16-bit integers onto 8 unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower target</param>
        /// <param name="hi">The upper target</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<ulong> vinflate8x512x64u(in ushort src)
            => (v64u(ConvertToVector256Int64(gptr(src))),
                v64u(ConvertToVector256Int64(gptr(src,4))));
    }
}