//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    using I = OpCodeFieldId;
    using RW = AsmFieldWidths;
    using DF = AsmDataField;

    public enum OpCodeFieldId
    {
        [FieldSynonym(DF.Sequence)]
        Sequence, 
        
        [FieldSynonym(DF.Mnemonic)]
        Mnemonic,  
        
        Expression, 
        
        Instruction, 
        
        M16,

        M32,

        M64,
        
        CpuId,
        
        [FieldSynonym(DF.OpCodeId)]
        Id,
    }

    public enum OpCodeField
    {
        Sequence = I.Sequence | (RW.Sequence << RW.Offset),

        Mnemonic = I.Mnemonic | (RW.Mnemonic << RW.Offset), 
        
        Expression = I.Expression | (RW.OpCode << RW.Offset),  
        
        Instruction = I.Instruction | (RW.Instruction << RW.Offset), 
        
        M16 = I.M16 | RW.YeaOrNea << RW.Offset,
        
        M32 = I.M32 | RW.YeaOrNea << RW.Offset,
        
        M64 = I.M64 | RW.YeaOrNea << RW.Offset,

        CpuId = I.CpuId | (RW.CpuId << RW.Offset),                 

        Id = I.Id | (RW.Id << RW.Offset),         
    }
}