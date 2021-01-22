//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmRegs;

    partial struct AsmBuilder
    {
        // [MethodImpl(Inline), Op]
        // public AsmStatement<Xmm,Xmm> vmovdqu(Xmm xmm1, Xmm xmm2)
        //     => statement("", xmm1, xmm2);
    }
}