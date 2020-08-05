//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = AsmRecordField;
    using R = AsmRecord;

    public struct AsmRecord : IRecord<F,R>
    {                   
        public static string FormatHeader(char delimiter = FieldDelimiter)
            => Tabular.HeaderText<F>(delimiter);
            
        public int Sequence;

        public MemoryAddress Address;

        public Address32 GlobalOfset;

        public Address16 LocalOffset;

		public asci16 Mnemonic;
		
		public asci32 OpCode;

        public BinaryCode Encoded;

        public asci32 InstructionFormat;

        public asci32 InstructionCode;
                
		public asci16 CpuId;

        public OpCodeId CodeId;

        [MethodImpl(Inline)]
        public AsmRecord(
            int Sequence, 
            MemoryAddress Address, 
            Address32 GlobalOffset, 
            Address16 LocalOffset, 
            asci16 Mnemonic, 
            asci32 OpCode, 
            BinaryCode Encoded, 
            asci32 InstructionFormat, 
            asci32 InstructionCode, 
            asci16 CpuId, 
            OpCodeId Id)
        {
            this.Sequence = Sequence;
            this.Address = Address;
            this.GlobalOfset = GlobalOffset;
            this.LocalOffset = LocalOffset;
            this.Mnemonic = Mnemonic;
            this.OpCode = OpCode;
            this.Encoded = Encoded;
            this.InstructionFormat = InstructionFormat;
            this.InstructionCode = InstructionCode;
            this.CpuId = CpuId;
            this.CodeId = Id;
        }

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => Sequence == 0 && CodeId == OpCodeId.INVALID;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public string DelimitedText(char delimiter)
        {
            var formatter = Tabular.Formatter<F>(delimiter);
            formatter.Delimit(F.Sequence, Sequence);
            formatter.Delimit(F.Address, Address);
            formatter.Delimit(F.GlobalOffset, GlobalOfset);
            formatter.Delimit(F.LocalOffset, LocalOffset);
            formatter.Delimit(F.Mnemonic, Mnemonic);
            formatter.Delimit(F.OpCode, OpCode);
            formatter.Delimit(F.Encoded, Encoded);
            formatter.Delimit(F.InstructionFormat, InstructionFormat);
            formatter.Delimit(F.InstructionCode, InstructionCode);
            formatter.Delimit(F.CpuId, CpuId);
            formatter.Delimit(F.CodeId, CodeId);
            return formatter.ToString();
        }

        public string Format()
            => DelimitedText(FieldDelimiter);

        public override string ToString()
            => Format();
        
        int ISequential.Sequence
            => 0;
    }
}