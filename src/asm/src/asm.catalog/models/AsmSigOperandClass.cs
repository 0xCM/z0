//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Pow2x16;

    [Flags]
    public enum AsmSigOperandClass : ushort
    {
        None = 0,

        Reg = P2ᐞ08,

        Mem = P2ᐞ09,

        Rm = P2ᐞ10,

        Imm = P2ᐞ11,

        NamedReg = P2ᐞ12
    }
}