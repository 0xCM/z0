//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    using Z0.Ice;

    public struct AsmStatementTrace
    {
        public BinaryCode Source;

        public MemoryAddress SourceBase;

        public Address16 Offset;

        public byte EncodedSize;

        public AsmStatementCode Statement;

        public IceInstructionData Data;

        public PackedInstruction Instruction;
    }
}