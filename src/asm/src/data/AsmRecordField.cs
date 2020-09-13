//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using W = AsmOpCodeFieldWidths;

    public enum AsmRecordField : uint
    {
        Sequence = 0 | (W.Sequence << WidthOffset),

        Address = 1 | (W.Address64 << WidthOffset),
        
        GlobalOffset = 2 | (16 << WidthOffset),

        LocalOffset = 3 | (16 << WidthOffset),

        Mnemonic = 4 | (W.Mnemonic << WidthOffset), 
        
        OpCode = 5 | (W.OpCode << WidthOffset),  
        
        Encoded = 6 | 32 << WidthOffset,

        InstructionFormat = 7 | (W.Instruction << WidthOffset), 

        InstructionCode = 8 | (W.Instruction << WidthOffset), 
        
        CpuId = 9 | (W.CpuId << WidthOffset),

        CodeId = 10 | (20 << WidthOffset),
    }
   
}