//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    using R = OpCodeFormRecord;
    using F = OpCodeFormField;

    using Asm.Data;

    public readonly struct OpCodeFormRecord : IRecord<F,R>
    {
        public static OpCodeFormRecord Empty => default;

		public int Sequence {get;}

        public readonly OpCodeId Id;

        public string Mnemonic {get;}

        public readonly BinaryCode CodeBytes;

        public readonly MandatoryPrefix Prefix;
        
        public readonly OpCodeTableKind Table;

        public readonly int Group;
		        
        public readonly OpCodeOperandKind Op1;

        public readonly OpCodeOperandKind Op2;

        public readonly OpCodeOperandKind Op3;

        public readonly OpCodeOperandKind Op4;

        public readonly OperandSize OpSize;

        public readonly AddressSize AddressSize;

        public readonly OpCodeFlags Flags;

        public OpCodeFormRecord(            
            int Sequence,
            OpCodeId Id, 
            string Mnemonic,
            BinaryCode CodeBytes, 
            MandatoryPrefix MandatoryPrefix,
            OpCodeTableKind TableKind,
            int GroupIndex,
            OpCodeFlags Flags,
            OperandSize OpSize,
            AddressSize AddressSize,
            params OpCodeOperandKind[] Operands
            )
        {
            this.Sequence = Sequence;
            this.Mnemonic = Mnemonic;
            this.Id = Id;
            this.CodeBytes = CodeBytes;
            this.Prefix = MandatoryPrefix;
            this.Table = TableKind;
            this.Group = GroupIndex;
            this.OpSize = OpSize;
            this.AddressSize = AddressSize;
            this.Flags = Flags;

            switch(Operands.Length)
            {
                case 1:
                    Op1 = Operands[0];
                    Op2 = default;
                    Op3 = default;
                    Op4 = default;
                    break;
                case 2:
                    Op1 = Operands[0];
                    Op2 = Operands[1];
                    Op3 = default;
                    Op4 = default;
                    break;
                case 3:
                    Op1 = Operands[0];
                    Op2 = Operands[1];
                    Op3 = Operands[2];
                    Op4 = default;
                    break;
                case 4:
                    Op1 = Operands[0];
                    Op2 = Operands[1];
                    Op3 = Operands[2];
                    Op4 = Operands[3];
                    break;
                default:
                    Op1 = default;
                    Op2 = default;
                    Op3 = default;
                    Op4 = default;
                break;
            }
        }    
    }
}