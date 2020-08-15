//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using W = AsmFieldWidths;
    using F = OpCodeRecordField;
    using R = OpCodeRecord;

    public enum OpCodeRecordField : uint
    {
        Sequence = 0 | (W.Sequence << WidthOffset),

        Mnemonic = 1 | (W.Mnemonic << WidthOffset), 

        OpCode = 2 | (W.OpCode << WidthOffset), 

        Instruction = 3 | (W.Instruction << WidthOffset), 

        M16 = 4 | (W.YeaOrNea << WidthOffset),

        M32 = 5 | (W.YeaOrNea << WidthOffset),
        
        M64 = 6 | (W.YeaOrNea << WidthOffset),

        CpuId = 7 | (W.CpuId << WidthOffset),

        CodeId = 8 | (W.OpCodeId << WidthOffset),
    }

}