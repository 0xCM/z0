//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using W = AsmFieldWidths;
    using F = OpCodeRecordField;
    using R = OpCodeRecord;

    public enum OpCodeRecordField : uint
    {
        Sequence = 0 | (W.Sequence << WidthOffset),

        Mnemonic = 1 | (W.Mnemonic << WidthOffset), 

        OpCode = 2 | (W.OpCode << WidthOffset), 

        Instruction = 3 | (W.Instruction << WidthOffset), 

        M16 = 4 | (W.YeaOrNea << WidthOffset),

        M32 = 5 | (W.YeaOrNea << WidthOffset),
        
        M64 = 6 | (W.YeaOrNea << WidthOffset),

        CpuId = 7 | (W.CpuId << WidthOffset),

        CodeId = 8 | (W.OpCodeId << WidthOffset),
    }

    public struct OpCodeRecord : IRecord<F,R>
    {                   
        public static string FormatHeader(char delimiter = FieldDelimiter)
            => Tabular.HeaderText<F>(delimiter);
            
        public int Sequence;

		public asci32 Mnemonic;
		
		public asci32 OpCode;

        public asci64 Instruction;

        public YeaOrNea M16;

        public YeaOrNea M32;

        public YeaOrNea M64;

		public asci64 CpuId;

        public OpCodeId CodeId;

        [MethodImpl(Inline)]
        public OpCodeRecord(
            int Sequence, 
            asci32 Mnemonic, 
            asci32 OpCode, 
            asci64 Instruction, 
            YeaOrNea M16, 
            YeaOrNea M32, 
            YeaOrNea M64, 
            asci64 CpuId, 
            OpCodeId Id)
        {
            this.Sequence = Sequence;
            this.Mnemonic = Mnemonic;
            this.OpCode = OpCode;
            this.Instruction = Instruction;
            this.M16 = M16;
            this.M32 = M32;
            this.M64 = M64;
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
            formatter.Delimit(F.Mnemonic, Mnemonic);
            formatter.Delimit(F.OpCode, OpCode);
            formatter.Delimit(F.Instruction, Instruction);
            formatter.Delimit(F.M16, M16);
            formatter.Delimit(F.M32, M32);
            formatter.Delimit(F.M64, M64);
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

        public static OpCodeRecord Empty 
            => default;
    }    
}