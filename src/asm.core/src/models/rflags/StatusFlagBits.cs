//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using RF = RFlags.RFlagBits;

    partial struct RFlags
    {
        [Flags,SymSource]
        public enum StatusFlagBits : ulong
        {
            [Symbol("cf", "Carry Flag")]
            CF = RF.CF,

            [Symbol("pf", "Parity Flag")]
            PF = RF.PF,

            [Symbol("af", "Adjust/Carry Flag")]
            AF = RF.AF,

            [Symbol("zf", "Zero Flag")]
            ZF = RF.ZF,

            [Symbol("sf", "Sign Flag")]
            SF = RF.SF,

            [Symbol("of", "Overflow Flag")]
            OF = RF.OF,
        }
    }
}