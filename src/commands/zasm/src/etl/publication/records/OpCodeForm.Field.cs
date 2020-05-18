//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    using static Tabular;

    using ID = OpCodeFormId;
    using W = OpCodeFormWidth;

    public enum OpCodeFormId : int
    {
        Sequence, Id, CodeBytes, Prefix, Table, Group,  

        Op1,    Op2,    Op3,    Op4,    
        
        OpSize, AddressSize,   Flags,        
    }

    public enum OpCodeFormWidth : int
    {
        Sequence = 10, Id = 50, CodeBytes = 16, Prefix = 8, Table = 8, Group = 8,    
        
        Op1 = 20, Op2 = 20, Op3 = 20, Op4 = 20,
        
        OpSize = 10,  AddressSize = 14, Flags = 10,  

        Offset = 16,        
    }

    public enum OpCodeFormField : int
    {
        Sequence = ID.Sequence | W.Sequence << W.Offset,

        Id = ID.Id | W.Id << W.Offset,

        CodeBytes = ID.CodeBytes | W.CodeBytes << W.Offset,

        Prefix = ID.Prefix | W.Prefix << W.Offset,

        Table = ID.Table | W.Table << W.Offset,

        Group = ID.Group | W.Group << W.Offset,

        Op1 = ID.Op1 | W.Op1 << W.Offset,

        Op2 = ID.Op2 | W.Op2 << W.Offset,

        Op3 = ID.Op3 | W.Op3 << W.Offset,

        Op4 = ID.Op4 | W.Op4 << W.Offset,

        OpSize = ID.OpSize | W.OpSize << W.Offset,

        AddressSize = ID.AddressSize | W.AddressSize << W.Offset,

        Flags = ID.Flags | W.Flags << W.Offset,
    }
}