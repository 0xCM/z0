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
        /// PMOVZXBQ xmm, m16
        /// 2x8u -> 2x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vinflate128x64u(in SpanBlock16<byte> src, uint offset)
            => v64u(ConvertToVector128Int64(gptr(src[offset])));

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// 2x16u -> 2x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vinflate128x64u(in SpanBlock32<ushort> src, uint offset)
            => v64u(ConvertToVector128Int64(gptr(src[offset])));

        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 2x8u -> 2x64u
        /// Projects 2 unsigned 8-bit values onto 2 unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="dst">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vinflate128x64u(in short src)
            => v64u(ConvertToVector128Int64(gptr(@as<byte>(src))));

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// 2x16u -> 2x64u
        /// Projects 2 unsigned 16-bit integers onto two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vmove2x64u(in ushort src)
            => v64u(ConvertToVector128Int64(gptr(src)));
    }
}