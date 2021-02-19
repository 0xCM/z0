//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Pow2x16;

    public enum AsmOpKind : ushort
    {
        None = 0,

        R = P2ᐞ00,

        M = P2ᐞ01,

        Imm = P2ᐞ02,

        W8 = P2ᐞ03,

        W16 = P2ᐞ04,

        W32 = P2ᐞ05,

        W64 = P2ᐞ06,

        W128 = P2ᐞ07,

        W256 = P2ᐞ08,

        W512 = P2ᐞ09,

        IO = P2ᐞ12,
    }
}