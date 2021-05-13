//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static memory;

    [ApiHost]
    public sealed class AsmRoutines : AppService<AsmRoutines>
    {
        /// <summary>
        /// Describes the instructions that comprise a function
        /// </summary>
        /// <param name="src">The source function</param>
        [Op]
        public static ReadOnlySpan<AsmInstructionInfo> summarize(AsmRoutine src)
        {
            var count = src.InstructionCount;
            var buffer = new AsmInstructionInfo[count];
            var offset = 0u;
            var @base = src.BaseAddress;
            var view = src.Instructions.View;
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var instruction = ref skip(view,i);
                var size = instruction.InstructionSize;

                if(src.Code.Size < offset + size)
                {
                    term.error($"Instruction size mismatch {instruction.IP} {offset} {src.Code.Size} {size}");
                    continue;
                }

                seek(dst, i) = IceExtractors.summarize(@base, instruction.Instruction, src.Code, instruction.Statment, offset);
                offset += size;
            }
            return dst;
        }

        [Op]
        public static uint filter(ReadOnlySpan<AsmMemberRoutine> src, Predicate<AsmMemberRoutine> predicate, Span<AsmMemberRoutine> dst)
        {
            var j=0u;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var candidate = ref skip(src,i);
                if(predicate(candidate))
                    seek(dst,j++) = candidate;
            }
            return j;
        }
    }
}