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

    using F = AsmRecordField;
    using R = AsmRecord;
    using api = asm;

    [StructLayout(LayoutKind.Sequential)]
    public struct AsmRecord : ITabular<F,R>, ITable<AsmRecordField,AsmRecord>
    {
        public int Sequence;

        public MemoryAddress Address;

        public Address32 GlobalOffset;

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
            this.GlobalOffset = GlobalOffset;
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
            => api.format(this,delimiter);

        public string Format()
            => DelimitedText(FieldDelimiter);

        public override string ToString()
            => Format();
    }
}