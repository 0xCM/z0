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

        W8 = P2ᐞ03,

        W16 = P2ᐞ04,

        W32 = P2ᐞ05,

        W64 = P2ᐞ06,

        W128 = P2ᐞ07,

        W256 = P2ᐞ08,

        W512 = P2ᐞ09,
    }
}