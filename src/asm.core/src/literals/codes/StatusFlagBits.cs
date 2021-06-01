//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using RF = RFlagBits;

    [Flags]
    public enum StatusFlagBits : uint
    {
        CF = RF.CF,

        PF = RF.PF,

        AF = RF.AF,

        ZF = RF.ZF,

        SF = RF.SF,

        OF = RF.OF,
    }
}