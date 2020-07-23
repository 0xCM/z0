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
     
    using static Konst;
    using static z;

    partial struct z
    {
        [MethodImpl(Inline), TestZ]
        public static bool testz(ulong a, ulong b)
            => TestZ(z.vbroadcast(w128,a), vbroadcast(w128,b));

        [MethodImpl(Inline), TestZ]
        public static bool testc(ulong a, ulong b)
            => TestC(z.vbroadcast(w128,a), vbroadcast(w128,b));

        [MethodImpl(Inline), TestZ]
        public static bool testc(ulong a)
            => TestC(z.vbroadcast(w128,a), vones<ulong>(w128));
    }
}