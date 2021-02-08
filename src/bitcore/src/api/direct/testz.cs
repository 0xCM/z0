//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static Part;

    partial class Bits
    {
        [MethodImpl(Inline), TestZ]
        public static bit testz(ulong a, ulong b)
            => TestZ(cpu.vbroadcast(w128, a), cpu.vbroadcast(w128, b));
   }
}