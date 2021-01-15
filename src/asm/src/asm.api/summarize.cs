//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct asm
    {

        /// <summary>
        /// Extracts operand instruction data
        /// </summary>
        /// <param name="fx">The source instruction</param>
        /// <param name="@base">The base address</param>
        [Op]
        static IceOperandInfo[] operands(MemoryAddress @base, in IceInstruction fx)
        {
            var count = fx.OpCount;
            var buffer = alloc<IceOperandInfo>(count);
            var dst = span(buffer);
            for(byte j=0; j<count; j++)
                seek(dst, j) = operand(@base, fx, j);
            return buffer;
        }

        [Op]
        public static AsmInstructionSummary summarize(MemoryAddress @base, in IceInstruction src, ReadOnlySpan<byte> encoded, string formatted, uint offset)
            => new AsmInstructionSummary(@base, offset,  formatted,  src.Specifier, operands(@base, src),  encoded.Slice((int)offset, src.ByteLength).ToArray());

        [Op]
        public static AsmInstructionSummary Summarize(MemoryAddress @base, in IceInstruction src, ReadOnlySpan<byte> encoded, string formatted, uint offset)
            => summarize(@base, src, encoded, formatted, offset);
    }
}