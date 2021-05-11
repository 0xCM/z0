//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    partial struct IceExtractors
    {
        [Op]
        public static AsmInstructionSummary summarize(MemoryAddress @base, IceInstruction src, CodeBlock encoded, AsmStatementExpr statement, uint offset)
            => new AsmInstructionSummary(@base, offset,  statement,  src.Specifier, operands(@base, src),  code(encoded, offset, src.InstructionSize));

        [MethodImpl(Inline), Op]
        public static BinaryCode code(CodeBlock encoded, uint offset, byte size)
            => slice(encoded.View, offset, size).ToArray();

        //encoded.Slice((int)offset, src.ByteLength).ToArray()
    }
}