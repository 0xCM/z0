//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ice
{
    using B = IceInstructionBytes;

    public enum IceInstructionFieldIndex : byte
    {
        NextRip = B.NextRipStart,

        CodeFlags = B.CodeFlagsStart,

        OpKindFlags = B.OpKindFlagsStart,

        Imm = B.ImmStart,

        MemDx = B.MemDxStart,

        MemFlags = B.MemFlagsStart,

        BaseReg = B.BaseRegStart,

        IndexReg = B.IndexRegStart,

        Reg0 = B.Reg0Start,

        Reg1 = B.Reg1Start,

        Reg2 = B.Reg2Start,

        Reg3 = B.Reg3Start
    }
}