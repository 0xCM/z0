//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using C = DataFieldWidths;

    /// <summary>
    /// Defines the widths of common asm record fields
    /// </summary>
    public enum AsmFieldWidths
    {
        Sequence = C.Sequence,

        Mnemonic = asci32.Size,

        Instruction = asci64.Size,

        OpCode = asci32.Size,

        OpCodeId = asci32.Size,
        
        Address64 = 16,

        YeaOrNea = C.Bool,


        CpuId = asci64.Size,
    }
}