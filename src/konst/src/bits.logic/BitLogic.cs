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

    public readonly partial struct BitLogic
    {
        [MethodImpl(Inline), TestZ]
        public static bit testz(ulong a, ulong b)
            => TestZ(cpu.vbroadcast(w128, a), cpu.vbroadcast(w128, b));

        [MethodImpl(Inline), TestZ]
        public static bit testc(ulong a, ulong b)
            => TestC(cpu.vbroadcast(w128, a), cpu.vbroadcast(w128, b));

        [MethodImpl(Inline), TestZ]
        public static bit testc(ulong a)
            => TestC(cpu.vbroadcast(w128, a), gcpu.vones<ulong>(w128));
    }
}