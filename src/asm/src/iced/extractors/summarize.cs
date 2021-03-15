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
        public static AsmInstructionSummary summarize(MemoryAddress @base, in IceInstruction src, ReadOnlySpan<byte> encoded, string formatted, uint offset)
            => new AsmInstructionSummary(@base, offset,  formatted,  src.Specifier, operands(@base, src),  encoded.Slice((int)offset, src.ByteLength).ToArray());

        [Op]
        public static AsmInstructionSummary Summarize(MemoryAddress @base, in IceInstruction src, ReadOnlySpan<byte> encoded, string formatted, uint offset)
            => summarize(@base, src, encoded, formatted, offset);
    }
}