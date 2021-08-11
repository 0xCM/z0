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

            Imm,

            Disp,

            Sib,

            ModRm,

            OpCode,

            Escape,

            RexPrefix,

            LegacyPrefix,

            VexC4,

            VexC5,

            RxbSelect,

            Vex,
        }
    }
}