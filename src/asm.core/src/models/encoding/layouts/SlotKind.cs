//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmLayouts
    {
        /// <summary>
        /// Classifies instruction layout segments, per AMD Vol3 1.2
        /// </summary>
        public enum SlotKind : byte
        {
            None = 0,

            Imm = 1,

            Disp = 2,

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
}