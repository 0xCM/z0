//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Record(TableId)]
    public struct AsmRow : IRecord<AsmRow>, IComparable<AsmRow>
    {
        public const string TableId = "asm.rows";

        public const byte FieldCount = 12;

        public uint Sequence;

        public MemoryAddress BlockAddress;

        public MemoryAddress IP;

        public Address32 GlobalOffset;

        public Address16 LocalOffset;

		public AsmMnemonic Mnemonic;

		public AsmOpCodeExpr OpCode;

        public string Instruction;

        public asci64 Statement;

        public BinaryCode Encoded;

		public asci16 CpuId;

        public string OpCodeId;

        [MethodImpl(Inline)]
        public int CompareTo(AsmRow src)
            => Sequence.CompareTo(src.Sequence);
    }
}