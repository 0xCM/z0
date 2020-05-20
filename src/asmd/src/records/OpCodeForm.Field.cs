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

    public enum OpCodeFormId : int
    {
        Sequence, Mnemonic, CodeBytes, Prefix, Table, Group,  

        Op1,    Op2,    Op3,    Op4,    
        
        OpSize, AddressSize, Id,  Flags,  
    }

    public enum OpCodeFormWidth : int
    {
        Mnemonic = 16, CodeBytes = 16, Prefix = 8, Table = 8, Group = 8,    
        
        Op1 = 20, Op2 = 20, Op3 = 20, Op4 = 20,
        
        OpSize = 10,  AddressSize = 14, Flags = 10,                  
    }

    public enum OpCodeFormField : int
    {
        Sequence = I.Sequence | RW.Sequence << RW.Offset,

        Mnemonic = I.Mnemonic | RW.Mnemonic << RW.Offset,
        
        CodeBytes = I.CodeBytes | W.CodeBytes << RW.Offset,

        Prefix = I.Prefix | W.Prefix << RW.Offset,

        Table = I.Table | W.Table << RW.Offset,

        Group = I.Group | W.Group << RW.Offset,

        Op1 = I.Op1 | W.Op1 << RW.Offset,

        Op2 = I.Op2 | W.Op2 << RW.Offset,

        Op3 = I.Op3 | W.Op3 << RW.Offset,

        Op4 = I.Op4 | W.Op4 << RW.Offset,

        OpSize = I.OpSize | W.OpSize << RW.Offset,

        AddressSize = I.AddressSize | W.AddressSize << RW.Offset,

        Id = I.Id | RW.Id << RW.Offset,
        
        Flags = I.Flags | W.Flags << RW.Offset,        
    }
}