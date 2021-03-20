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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static Part;
    using static memory;

    partial struct cpu
    {
        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 4x8u -> 4x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vinflate128x32u(in SpanBlock32<byte> src, uint offset)
            => v32u(ConvertToVector128Int32(gptr(src[offset])));

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 4x16u -> 4x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vinflate128x32u(in SpanBlock64<ushort> src, uint offset)
            => v32u(ConvertToVector128Int32(gptr(src[offset])));
    }
}