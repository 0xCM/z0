//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    using F = Asm.AsmRowField;

    public enum AsmRowField : uint
    {
        Sequence = 0 | (10 << WidthOffset),

        Address = 1 | (16 << WidthOffset),

        GlobalOffset = 2 | (16 << WidthOffset),

        LocalOffset = 3 | (16 << WidthOffset),

        Mnemonic = 4 | (16 << WidthOffset),

        OpCode = 5 | (32 << WidthOffset),

        Instruction = 6 | (64 << WidthOffset),

        SourceCode = 7 | (64 << WidthOffset),

        Encoded = 8 | 32 << WidthOffset,

        CpuId = 9 | (64 << WidthOffset),

        OpCodeId = 10 | (20 << WidthOffset),
    }

    [StructLayout(LayoutKind.Sequential), Record(TableId, FieldCount)]
    public struct AsmRow
    {
        public const string TableId = "asm.rows";

        public const byte FieldCount = 11;

        public int Sequence;

        public MemoryAddress Address;

        public Address32 GlobalOffset;

        public Address16 LocalOffset;

		public asci16 Mnemonic;

		public AsmOpCodePattern OpCode;

        public AsmInstructionPattern Instruction;

        public asci64 SourceCode;

        public BinaryCode Encoded;

		public asci16 CpuId;

        public OpCodeId OpCodeId;

        [MethodImpl(Inline)]
        public AsmRow(
            int Sequence,
            MemoryAddress Address,
            Address32 GlobalOffset,
            Address16 LocalOffset,
            asci16 Mnemonic,
            AsmOpCodePattern OpCode,
            BinaryCode Encoded,
            AsmInstructionPattern Instruction,
            asci64 SourceCode,
            asci16 CpuId,
            OpCodeId Id)
        {
            this.Sequence = Sequence;
            this.Address = Address;
            this.GlobalOffset = GlobalOffset;
            this.LocalOffset = LocalOffset;
            this.Mnemonic = Mnemonic;
            this.OpCode = OpCode;
            this.Instruction = Instruction;
            this.SourceCode = SourceCode;
            this.Encoded = Encoded;
            this.CpuId = CpuId;
            this.OpCodeId = Id;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Sequence == 0 && OpCodeId == OpCodeId.INVALID;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        [Op]
        public static ref readonly DatasetFormatter<AsmRowField> format(in AsmRow src, in DatasetFormatter<AsmRowField> dst)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Address, src.Address);
            dst.Delimit(F.GlobalOffset, src.GlobalOffset);
            dst.Delimit(F.LocalOffset, src.LocalOffset);
            dst.Delimit(F.Mnemonic, src.Mnemonic);
            dst.Delimit(F.OpCode, src.OpCode);
            dst.Delimit(F.Instruction, src.Instruction);
            dst.Delimit(F.SourceCode, src.SourceCode);
            dst.Delimit(F.Encoded, src.Encoded);
            dst.Delimit(F.CpuId, src.CpuId);
            dst.Delimit(F.OpCodeId, src.OpCodeId);
            return ref dst;
        }
    }
}