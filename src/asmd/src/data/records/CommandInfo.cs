//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using F = CommandInfoField;
    using R = CommandInfo;
    using W = AsmFieldWidths;

    public enum CommandInfoField : uint
    {
        Sequence = 0 | (W.Sequence << W.Offset),

        Offset = 1 | (W.Address16 << W.Offset),

        Mnemonic = 2 | (W.Mnemonic << W.Offset), 
        
        OpCode = 3 | (W.OpCode << W.Offset),  
        
        Encoded = 4 | 32 << W.Offset,

        InstructionFormat = 5 | (W.Instruction << W.Offset), 

        InstructionCode = 6 | (W.Instruction << W.Offset), 
        
        CpuId = 7 | (W.CpuId << W.Offset),

        CodeId = 8 | (20 << W.Offset),                          
    }

    public struct CommandInfo : IRecord<F,R>
    {                   
        public static string FormatHeader(char delimiter = Chars.Pipe)
            => Records.Header<F>().Render(delimiter);
        
        public static CommandInfo Empty 
            => new CommandInfo(0,Address16.Empty, asci16.Null, asci32.Null, BinaryCode.Empty, asci32.Null, asci32.Null, asci16.Null, OpCodeId.INVALID);        
        
        public int Sequence 
            => Seq;
        
        public int Seq;

        public Address16 Offset;

		public asci16 Mnemonic;
		
		public asci32 OpCode;

        public BinaryCode Encoded;

        public asci32 InstructionFormat;

        public asci32 InstructionCode;
                
		public asci16 CpuId;

        public OpCodeId CodeId;

        [MethodImpl(Inline)]
        public CommandInfo(int Seq, Address16 Offset, asci16 Mnemonic, asci32 OpCode, BinaryCode Encoded, asci32 InstructionFormat, asci32 InstructionCode, asci16 CpuId, OpCodeId Id)
        {
            this.Seq = Seq;
            this.Offset = Offset;
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

        public string Format()
        {
            var formatter = Records.Formatter<F>();
            formatter.DelimitField(F.Sequence, Seq);
            formatter.DelimitField(F.Offset, Offset);
            formatter.DelimitField(F.Mnemonic, Mnemonic);
            formatter.DelimitField(F.OpCode, OpCode);
            formatter.DelimitField(F.Encoded, Encoded);
            formatter.DelimitField(F.InstructionFormat, InstructionFormat);
            formatter.DelimitField(F.InstructionCode, InstructionCode);
            formatter.DelimitField(F.CpuId, CpuId);
            formatter.DelimitField(F.CodeId, CodeId);
            return formatter.ToString();
        }
    }
}