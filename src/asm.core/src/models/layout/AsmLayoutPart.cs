//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Classifies instruction layout segments, per AMD Vol3 1.2
    /// </summary>
    public enum AsmLayoutPart : byte
    {
        None = 0,

        Imm = 1,

        Dx = 2,

        Sib = 3,

        ModRm = 4,

        OpCode = 5,

        Escape = 6,

        RexPrefix = 7,

        LegacyPrefix = 8,

        VexC5 = 9,

        RxbSelect = 10,

        Vex = 11,

        Xop = 12
    }
}