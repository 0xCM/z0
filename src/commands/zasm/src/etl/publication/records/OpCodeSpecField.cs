//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    using I = OpCodeSpecFieldId;
    using W = OpCodeSpecFieldWidth;
    using R = RecordFields;
    using RW = RecordFieldWidths;

    public enum OpCodeSpecFieldId
    {
        Sequence, Mnemonic,  Expression, Instruction, Modes,  CpuId,  Id, 
    }

    public enum OpCodeSpecFieldWidth
    {
        Sequence = R.SeqWidth, Mnemonic = 16, Expression = RW.OpCode, Instruction = 60, Modes = 16,  CpuId = 10,  Id = R.IdWidth, 
    }

    public enum OpCodeSpecField
    {
        Sequence = I.Sequence | (RW.Sequence << RW.Offset),

        Mnemonic = I.Mnemonic | (RW.Mnemonic << RW.Offset), 
        
        Expression = I.Expression | (W.Expression << RW.Offset),  
        
        Instruction = I.Instruction | (RW.Instruction << RW.Offset), 
        
        Modes = I.Modes | (W.Modes << RW.Offset),  
        
        CpuId = I.CpuId | (W.CpuId << RW.Offset),                 

        Id = I.Id | (W.Id << RW.Offset), 
        
    }
}