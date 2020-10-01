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

    [StructLayout(LayoutKind.Sequential)]
    public struct AsmRow
    {
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
    }
}