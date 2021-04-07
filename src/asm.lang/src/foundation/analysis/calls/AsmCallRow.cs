//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [Record(TableId)]
    public struct AsmCallRow : IRecord<AsmCallRow>
    {
        public const string TableId = "asm.calls";

        public const byte FieldCount = 6;

        public MemoryAddress Source;

        public MemoryAddress Target;

        public ByteSize InstructionSize;

        public MemoryAddress TargetOffset;

        public AsmStatementExpr Instruction;

        public BinaryCode Encoded;
    }
}