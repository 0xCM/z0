//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Pow2x16;

    [Flags]
    public enum AsmOpKind : ushort
    {
        None = 0,

        R = AsmOpClass.R,

        M = AsmOpClass.M,

        Imm = AsmOpClass.Imm,
    }
}