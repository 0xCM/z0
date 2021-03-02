//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public enum AsmRowField : uint
    {
        Sequence = 0 | (10 << WidthOffset),

        BlockAddress = 1 | (16 << WidthOffset),

        IP = 2 | (16 << WidthOffset),

        GlobalOffset = 3 | (16 << WidthOffset),

        LocalOffset = 4 | (16 << WidthOffset),

        Mnemonic = 5 | (16 << WidthOffset),

        OpCode = 6 | (32 << WidthOffset),

        Instruction = 7 | (64 << WidthOffset),

        Statement = 8 | (64 << WidthOffset),

        Encoded = 9 | 32 << WidthOffset,

        CpuId = 10 | (64 << WidthOffset),

        OpCodeId = 11 | (20 << WidthOffset),
    }

    public enum AsmRowFieldWidth : uint
    {
        Sequence = 10,

        BlockAddress =  16,

        IP = 16,

        GlobalOffset = 16,

        LocalOffset = 16,

        Mnemonic = 16,

        OpCode = 32,

        Instruction = 64,

        Statement = 64,

        Encoded = 32,

        CpuId = 64,

        OpCodeId = 20,
    }

    [Record(TableId)]
    public struct AsmRow : IRecord<AsmRow>, IComparable<AsmRow>
    {
        public const string TableId = "asm.rows";

        public uint Sequence;

        public MemoryAddress BlockAddress;

        public MemoryAddress IP;

        public Address32 GlobalOffset;

        public Address16 LocalOffset;

		public TextBlock<N16> Mnemonic;

		public AsmOpCodeExprLegacy OpCode;

        public string Instruction;

        public asci64 Statement;

        public BinaryCode Encoded;

		public asci16 CpuId;

        public IceOpCodeId OpCodeId;

        [MethodImpl(Inline)]
        public int CompareTo(AsmRow src)
            => Sequence.CompareTo(src.Sequence);
    }
}