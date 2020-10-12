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

    [StructLayout(LayoutKind.Sequential), Table(TableId, FieldCount)]
    public struct AsmCallRecord
    {
        public const string TableId = "asm.calls";

        public const byte FieldCount = 5;

        public MemoryAddress Source;

        public MemoryAddress Target;

        public ByteSize InstructionSize;

        public MemoryAddress TargetOffset;

        public BinaryCode Encoded;
    }
}