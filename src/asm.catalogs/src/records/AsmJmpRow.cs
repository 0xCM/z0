//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    using Z0.Asm;

    partial struct AsmRecords
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct AsmJmpRow : IRecord<AsmJmpRow>
        {
            public const string TableId = "asm.jumps";

            public MemoryAddress Base;

            public MemoryAddress Source;

            public ByteSize InstructionSize;

            public MemoryAddress CallSite;

            public MemoryAddress Target;

            public JmpKind Kind;

            public AsmStatementExpr Asm;
        }
    }

}