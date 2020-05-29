//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    using I = OpCodeFormId;
    using W = OpCodeFormWidth;
    using RW = AsmFieldWidths;
    using DF = AsmDataField;

    /*
        GroupIndex = (sbyte)((dword2 & (uint)LegacyFlags.HasGroupIndex) == 0 ? -1 : (int)((dword2 >> (int)LegacyFlags.GroupShift) & 7));
        Flags: 
            HasGroupIndex = 0x00000040,
		    GroupShift = 0x00000007
	
    */
    public enum OpCodeFormId : int
    {
        Sequence, 
        
        Mnemonic, 
        
        [Comment("")]
        CodeBytes, 
        
        [Comment("")]
        Prefix, 
        
        [Comment("Gets the opcode table")]
        Table, 
        
        [Comment("Group index (0-7) or -1. If it's 0-7, it's stored in the reg field of the modrm byte.")]
        Group,  

        [Comment("")]
        Op1, 

        [Comment("")]
        Op2,    

        [Comment("")]
        Op3,  

        [Comment("")]
        Op4,    
        
        [Comment("")]
        OpSize, 
        
        [Comment("")]
        AddressSize, 
        
        Id,  
        
        [Comment("")]
        Flags,  
    }

    public enum OpCodeFormWidth : int
    {
        Prefix = 8, Table = 8, Group = 8,            
        
        OpSize = 10,  Flags = 10,                  
    }

    public enum OpCodeFormField : int
    {
        Sequence = I.Sequence | RW.Sequence << RW.Offset,

        Mnemonic = I.Mnemonic | RW.Mnemonic << RW.Offset,
        
        CodeBytes = I.CodeBytes | RW.OpCodeBytes << RW.Offset,

        Prefix = I.Prefix | W.Prefix << RW.Offset,

        Table = I.Table | W.Table << RW.Offset,

        Group = I.Group | W.Group << RW.Offset,

        Op1 = I.Op1 | RW.Operand << RW.Offset,

        Op2 = I.Op2 | RW.Operand << RW.Offset,

        Op3 = I.Op3 | RW.Operand << RW.Offset,

        Op4 = I.Op4 | RW.Operand << RW.Offset,

        OpSize = I.OpSize | W.OpSize << RW.Offset,

        AddressSize = I.AddressSize | RW.Address64 << RW.Offset,

        Id = I.Id | RW.Id << RW.Offset,
        
        Flags = I.Flags | W.Flags << RW.Offset,        
    }
}