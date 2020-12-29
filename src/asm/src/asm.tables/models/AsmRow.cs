//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

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
    public struct AsmRow : IRecord<AsmRow>, IComparable<AsmRow>
    {
        public const string TableId = "asm.rows";

        public const byte FieldCount = 11;

        public Sequential Sequence;

        public MemoryAddress Address;

        public Address32 GlobalOffset;

        public Address16 LocalOffset;

		public asci16 Mnemonic;

		public AsmOpCodePattern OpCode;

        public AsmSig Instruction;

        public asci64 SourceCode;

        public BinaryCode Encoded;

		public asci16 CpuId;

        public OpCodeId OpCodeId;

        [MethodImpl(Inline)]
        public AsmRow(
            Sequential Sequence,
            MemoryAddress Address,
            Address32 GlobalOffset,
            Address16 LocalOffset,
            asci16 Mnemonic,
            AsmOpCodePattern OpCode,
            BinaryCode Encoded,
            AsmSig Instruction,
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

        [MethodImpl(Inline)]
        public int CompareTo(AsmRow src)
            => Sequence.CompareTo(src.Sequence);
    }
}