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

        public MemoryAddress Source;

        public MemoryAddress Target;

        public ByteSize InstructionSize;

        public MemoryAddress TargetOffset;

        public string Instruction;

        public BinaryCode Encoded;
    }
}