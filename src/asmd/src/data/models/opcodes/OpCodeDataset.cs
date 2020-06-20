//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;    
    
    public readonly struct OpCodeDataset
    {
        [MethodImpl(Inline)]
        public static OpCodeDataset Create()
            => new OpCodeDataset(0);
        
        public readonly int OpCodeCount;
        
        public readonly OpCodeRecord[] OpCodeRecords;

        public readonly AppResourceDoc ResourceDoc;

        public readonly OpCodeIdentifier[] OpCodeIdentifiers;

        public const byte EncodingDelimiter = 0xFF;

        [MethodImpl(Inline), Op]
        public OpCodeIdentifier opcode(int index)
            => OpCodeIdentifiers[index];

        [MethodImpl(Inline)]
        OpCodeDataset(int i)
        {
            ResourceDoc = AsmD.Service.OpCodeSpecDoc;
            OpCodeCount = ResourceDoc.RowCount;
            OpCodeRecords = new OpCodeRecord[OpCodeCount];
            CommandInfoParser.Service.Parse(ResourceDoc, OpCodeRecords);
            OpCodeIdentifiers = new OpCodeIdentifier[OpCodeCount];
            OpCodeIdentity.Service.Compute(OpCodeRecords, OpCodeIdentifiers);
        }
    }
}