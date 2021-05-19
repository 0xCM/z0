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
}