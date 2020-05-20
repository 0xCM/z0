//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    using I = OpCodeSpecFieldId;
    using W = OpCodeSpecFieldWidth;
    using RW = AsmFieldWidths;

    public enum OpCodeSpecFieldId
    {
        Sequence, Mnemonic,  Expression, Instruction, Modes,  CpuId,  Id, 
    }

    public enum OpCodeSpecFieldWidth
    {
        Expression = RW.OpCode, Modes = 16,  CpuId = 10, 
    }

    public enum OpCodeSpecField
    {
        Sequence = I.Sequence | (RW.Sequence << RW.Offset),

        Mnemonic = I.Mnemonic | (RW.Mnemonic << RW.Offset), 
        
        Expression = I.Expression | (W.Expression << RW.Offset),  
        
        Instruction = I.Instruction | (RW.Instruction << RW.Offset), 
        
        Modes = I.Modes | (W.Modes << RW.Offset),  
        
        CpuId = I.CpuId | (W.CpuId << RW.Offset),                 

        Id = I.Id | (RW.Id << RW.Offset), 
        
    }
}