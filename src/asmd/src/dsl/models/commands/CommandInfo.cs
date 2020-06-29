//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = CommandInfoField;
    using R = CommandInfo;
    using W = AsmFieldWidths;

    public enum CommandInfoField : uint
    {
        Sequence = 0 | (W.Sequence << WidthOffset),

        Address = 1 | (W.Address64 << WidthOffset),
        
        GlobalOffset = 2 | (16 << WidthOffset),

        LocalOffset = 3 | (16 << WidthOffset),

        Mnemonic = 4 | (W.Mnemonic << WidthOffset), 
        
        OpCode = 5 | (W.OpCode << WidthOffset),  
        
        Encoded = 6 | 32 << WidthOffset,

        InstructionFormat = 7 | (W.Instruction << WidthOffset), 

        InstructionCode = 8 | (W.Instruction << WidthOffset), 
        
        CpuId = 9 | (W.CpuId << WidthOffset),

        CodeId = 10 | (20 << WidthOffset),
    }

    public struct CommandInfo : IRecord<F,R>
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
        public CommandInfo(
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

        public static CommandInfo Empty 
            => new CommandInfo(0, 0, 0, 0, asci.Null, asci.Null, BinaryCode.Empty, asci.Null, asci.Null, asci.Null, 0);        
    }
}