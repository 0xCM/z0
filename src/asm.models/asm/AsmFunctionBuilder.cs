//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AsmFxCheck;

    public readonly struct AsmFunctionBuilder : IAsmFunctionBuilder
    {        
        public static AsmFunctionBuilder Service => default;
        
        public bool RunChecks {get;}

        public AsmFunction BuildFunction(OpUri uri, string sig, AsmInstructionBlock src)
        {
            var info = new AsmInstructionSummary[src.InstructionCount];
            var offset = (ushort)0;
            var @base = src.BaseAddress;

            for(var i=0; i<info.Length; i++)
            {
                var instruction = src[i];                
                if(RunChecks)
                    CheckInstructionSize(instruction, offset, src);

                info[i] = asm.summarize(@base, instruction,src.Encoded.Encoded, instruction.FormattedInstruction, offset);
                offset += (ushort)instruction.ByteLength;
            }

            if(RunChecks)
                CheckBlockLength(src);

            var instructions = AsmInstructionList.Create(src.Decoded, src.Encoded.Encoded);
            return new AsmFunction(uri, sig, src.Encoded, src.TermCode, instructions);            
        }
    }
}