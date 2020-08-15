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

        /// <summary>
        /// Describes the instructions that comprise an instruction list
        /// </summary>
        /// <param name="src">The source instruction list</param>
        [Op]
        public static AsmInstructionSummary[] summarize(AsmInstructionList src)
        {
            var dst = new AsmInstructionSummary[src.Length];
            var offset = (ushort)0;
            var @base = src.Encoded.Address;

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src[i];                            
                dst[i] =   Asm.asm.Summarize(@base, instruction, src.Encoded, instruction.FormattedInstruction, offset );
                offset += (ushort)instruction.ByteLength;
            }
            return dst;
        }

    }
}