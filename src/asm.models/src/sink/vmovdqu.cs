//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmSink
    {
        public AsmArgs<Xmm,Xmm> vmovdqu(Xmm xmm1, Xmm xmm2)
            => args(xmm1,xmm2);
    }
}