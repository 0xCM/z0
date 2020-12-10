//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [Record(TableId)]
    public struct AsmJmpInfo : IRecord<AsmJmpInfo>
    {
        public const string TableId = "asm.jumps";

        public MemoryAddress Base;

        public MemoryAddress Source;

        public ByteSize InstructionSize;

        public MemoryAddress CallSite;

        public MemoryAddress Target;

        public JccKind Kind;

        public string Asm;
    }
}