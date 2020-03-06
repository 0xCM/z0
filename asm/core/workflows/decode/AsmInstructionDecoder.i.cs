//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using Z0.Asm;

    public interface IAsmInstructionDecoder : IAsmService
    {
        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        Option<AsmInstructionList> DecodeInstructions(AsmCode src);        

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        Option<AsmInstructionList> DecodeInstructions(MemoryExtract src);        
    }
}