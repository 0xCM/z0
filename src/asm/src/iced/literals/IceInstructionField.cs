//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ice
{
    public enum IceInstructionField : byte
    {
        NextRip = 0,

        CodeFlags = 1,

        OpKindFlags = 2,

        Imm = 3,

        MemDx = 4,

        MemFlags = 5,

        BaseReg = 6,

        IndexReg = 7,

        Reg0 = 8,

        Reg1 = 9,

        Reg2 = 10,

        Reg3 = 11
    }
}