//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using Z0.Asm;

    partial struct asm
    {
        [Op]
        public static AsmFxSummary summarize(MemoryAddress @base, in Instruction src, ReadOnlySpan<byte> encoded, string formatted, uint offset)
            => new AsmFxSummary(@base, offset,  formatted,  src.InstructionCode, operands(@base, src),  encoded.Slice((int)offset, src.ByteLength).ToArray());

        [Op]
        public static AsmFxSummary Summarize(MemoryAddress @base, in Instruction src, ReadOnlySpan<byte> encoded, string formatted, uint offset)
            => summarize(@base, src, encoded, formatted, offset);

        /// <summary>
        /// Describes the instructions that comprise an instruction list
        /// </summary>
        /// <param name="src">The source instruction list</param>
        [Op]
        public static ReadOnlySpan<AsmFxSummary> summarize(in AsmFxList src)
        {
            var count = src.Length;
            var buffer = new AsmFxSummary[count];
            var offset = 0u;
            var @base = src.Encoded.Base;
            var view = src.View;
            var dst = span(buffer);

            for(var i=0u; i<count; i++)
            {
                ref readonly var instruction = ref skip(view,i);
                seek(dst,i) = asm.Summarize(@base, instruction, src.Encoded, instruction.FormattedInstruction, offset);
                var size = (uint)instruction.ByteLength;
                offset += size;
            }
            return buffer;
        }

        /// <summary>
        /// Describes the instructions that comprise a function
        /// </summary>
        /// <param name="src">The source function</param>
        public static ReadOnlySpan<AsmFxSummary> summarize(in AsmRoutine src)
        {
            var count = src.InstructionCount;
            var buffer = new AsmFxSummary[count];
            var offset = 0u;
            var @base = src.BaseAddress;
            var view = src.Instructions.View;
            var dst = span(buffer);

            for(var i=0u; i<count; i++)
            {
                ref readonly var instruction = ref skip(view,i);
                var size = (uint)instruction.ByteLength;

                if(src.Code.Length < offset + size)
                {
                    term.error($"Instruction size mismatch {instruction.IP} {offset} {src.Code.Length} {size}");
                    continue;
                }

                seek(dst, i) = asm.summarize(@base, instruction, src.Code.Encoded, instruction.FormattedInstruction, offset);
                offset += size;
            }
            return dst;
        }
    }
}