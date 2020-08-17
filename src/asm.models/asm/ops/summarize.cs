//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using Z0.Asm;

    partial struct asm
    { 
        [MethodImpl(Inline), Op]
        public static AsmFxSummary summarize(MemoryAddress @base, Instruction src, ReadOnlySpan<byte> encoded, string formatted, ushort offset)
            => new AsmFxSummary(@base, (ushort)offset,  formatted,  src.InstructionCode, operands(@base, src),  encoded.Slice(offset, src.ByteLength).ToArray());

        [MethodImpl(Inline), Op]
        public static AsmFxSummary Summarize(MemoryAddress @base, Instruction src, ReadOnlySpan<byte> encoded, string formatted, ushort offset)
            => summarize(@base, src, encoded, formatted, offset);

        /// <summary>
        /// Describes the instructions that comprise an instruction list
        /// </summary>
        /// <param name="src">The source instruction list</param>
        [Op]
        public static ReadOnlySpan<AsmFxSummary> summarize(AsmFxList src)
        {
            var dst = new AsmFxSummary[src.Length];
            var offset = (ushort)0;
            var @base = src.Encoded.Address;

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src[i];                            
                dst[i] =   asm.Summarize(@base, instruction, src.Encoded, instruction.FormattedInstruction, offset);
                offset += (ushort)instruction.ByteLength;
            }
            return dst;
        }

        /// <summary>
        /// Describes the instructions that comprise a function
        /// </summary>
        /// <param name="src">The source function</param>
        [Op]
        public static ReadOnlySpan<AsmFxSummary> summarize(in AsmRoutine src)
        {
            var dst = new AsmFxSummary[src.InstructionCount];
            var offset = (ushort)0;
            var @base = src.BaseAddress;

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src.Instructions[i];
                
                if(src.Code.Length < offset + instruction.ByteLength)
                {
                    term.error($"Instruction size mismatch {instruction.IP} {offset} {src.Code.Length} {instruction.ByteLength}");
                    continue;
                }
            
                dst[i] = asm.summarize(@base, instruction, src.Code.Encoded, instruction.FormattedInstruction, offset);
                offset += (ushort)instruction.ByteLength;
            }
            return dst;
        }
    }
}