//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public enum AsmSigTokenKind : byte
    {
        None = 0,

        GpReg,

        VecReg,

        MaskReg,

        FpuReg,

        SysReg,

        MmxReg,

        Imm,

        Mem,

        FpuMem,

        GpRm,

        VecRm,

        Moffs,

        Rel,

        SrcOp,

        Ptr,

        ZmmBCast,

        Rounding,

        FarPtr,

        MemPair,

        Vsib,

        Broadcast,

        XmmReg,

        YmmReg,

        ZmmReg
    }
}