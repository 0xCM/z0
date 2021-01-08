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
    using static z;

    public readonly partial struct BitLogic
    {
        [MethodImpl(Inline), TestZ]
        public static bool testz(ulong a, ulong b)
            => TestZ(vbroadcast(w128, a), vbroadcast(w128,b));

        [MethodImpl(Inline), TestZ]
        public static bool testc(ulong a, ulong b)
            => TestC(vbroadcast(w128, a), vbroadcast(w128,b));

        [MethodImpl(Inline), TestZ]
        public static bool testc(ulong a)
            => TestC(vbroadcast(w128, a), vones<ulong>(w128));
    }
}