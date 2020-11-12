//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ice
{
    
    public enum InstructionBits : byte
    {
        RipWidth = 64,
        
        CodeFlagsWidth = 32,

        OpKindFlagsWidth = 32,

        ImmWidth = 32,

        MemDxWidth = 32,

        MemFlagsWidth = 16,

        RegWidth = 8,

        NextRipStart = 0,

        NextRipEnd = RipWidth - 1,

        CodeFlagsStart = NextRipEnd + 1,

        CodeFlagsEnd = CodeFlagsStart + CodeFlagsWidth - 1,

        OpKindFlagsStart = CodeFlagsEnd + 1,

        OpKindFlagsEnd = OpKindFlagsStart + OpKindFlagsWidth - 1,

        ImmStart = OpKindFlagsEnd + 1,

        ImmEnd = ImmStart + ImmWidth - 1,

        MemDxStart = ImmEnd + 1,

        MemDxEnd = MemDxStart + MemDxWidth - 1,

        MemFlagsStart = MemDxEnd + 1,

        MemFlagsEnd = MemFlagsStart + MemFlagsWidth - 1,

        MemBaseRegStart = MemFlagsEnd + 1,

        MemBaseRegEnd = MemBaseRegStart + RegWidth - 1,

        MemIndexRegStart = MemBaseRegEnd + 1,

        MemIndexRegEnd = MemIndexRegStart + RegWidth - 1,

        Reg0Start = MemIndexRegEnd + 1,

        Reg0End = Reg0Start + RegWidth - 1,

        Reg1Start = Reg0End + 1,

        Reg1End = Reg1Start + RegWidth - 1,

        Reg2Start = Reg1End + 1,

        Reg2End = Reg2Start + RegWidth - 1,

        Reg3Start = Reg2End + 1,

        Reg3End = Reg3Start + RegWidth - 1,
    }
}