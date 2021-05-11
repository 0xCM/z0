//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial struct IceExtractors
    {
        [Op]
        public static AsmInstructionSummary summarize(MemoryAddress @base, IceInstruction src, CodeBlock encoded, AsmStatementExpr statement, uint offset)
            => new AsmInstructionSummary(@base, offset,  statement,  src.Specifier, operands(@base, src),  encoded);

        //encoded.Slice((int)offset, src.ByteLength).ToArray()
    }
}