//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct OpCodeDataset
    {
        [MethodImpl(Inline)]
        public static OpCodeDataset Create()
            => new OpCodeDataset(0);
        
        public readonly Token[] ITokens;

        public readonly string[] ITokenPurpose;

        public readonly string[] ITokenIdentity;

        public readonly string[] ITokenValues;

        public readonly int OpCodeCount;
        
        public readonly OpCodeRecord[] Records;

        public readonly AppResourceDoc ResourceDoc;

        public readonly OpCodeIdentifier[] OpCodeIdentifiers;

        [MethodImpl(Inline)]
        OpCodeDataset(int i)
        {
            ITokens = InstructionTokenData.Tokens;
            ITokenPurpose = InstructionTokenData.Purposes;
            ITokenIdentity = InstructionTokenData.Identity;
            ITokenValues = InstructionTokenData.Values;
            ResourceDoc = OpCodeServices.LoadResource().Require();
            OpCodeCount = ResourceDoc.RowCount;
            Records = new OpCodeRecord[OpCodeCount];
            OpCodeRecordParser.Service.Parse(ResourceDoc,Records);
            OpCodeIdentifiers = new OpCodeIdentifier[OpCodeCount];
            OpCodeIdentity.Service.Compute(Records,OpCodeIdentifiers);
        }
    }
}