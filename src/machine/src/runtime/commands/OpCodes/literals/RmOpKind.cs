//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using Z0.Asm.Data;

    using R = RegOpKind;
    using F = OpKindFlags;

    public enum RmOpKind : byte
    {
        None,
            
        rm8 = R.r8 | F.rm,

        rm16 = R.r16 | F.rm,

        rm32 = R.r32 | F.rm,

        rm64 = R.r64 | F.rm,

        rxmm = R.xmm | F.rm,

        rymm = R.ymm | F.rm,

        rzmm = R.zmm | F.rm,
    }
}