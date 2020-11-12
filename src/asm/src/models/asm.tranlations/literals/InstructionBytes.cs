//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ice
{
    using S = InstructionFieldSize;

    public enum InstructionBytes : byte
    {
        NextRipStart = 0,

        NextRipEnd = S.NextRip - 1,

        CodeFlagsStart = NextRipEnd + 1,

        CodeFlagsEnd = CodeFlagsStart + S.CodeFlags - 1,

        OpKindFlagsStart = CodeFlagsEnd + 1,

        OpKindFlagsEnd = OpKindFlagsStart + S.OpKindFlags - 1,

        ImmStart = OpKindFlagsEnd + 1,

        ImmEnd = ImmStart + S.Imm - 1,

        MemDxStart = ImmEnd + 1,

        MemDxEnd = MemDxStart + S.MemDx - 1,

        MemFlagsStart = MemDxEnd + 1,

        MemFlagsEnd = MemFlagsStart + S.MemFlags - 1,

        BaseRegStart = MemFlagsEnd + 1,

        BaseRegEnd = BaseRegStart + S.BaseReg - 1,

        IndexRegStart = BaseRegEnd + 1,

        IndexRegEnd = IndexRegStart + S.IndexReg - 1,

        Reg0Start = IndexRegEnd + 1,

        Reg0End = Reg0Start + S.Reg0 - 1,

        Reg1Start = Reg0End + 1,

        Reg1End = Reg1Start + S.Reg1 - 1,

        Reg2Start = Reg1End + 1,

        Reg2End = Reg2Start + S.Reg2 - 1,

        Reg3Start = Reg2End + 1,

        Reg3End = Reg3Start + S.Reg3 - 1,
    }
}