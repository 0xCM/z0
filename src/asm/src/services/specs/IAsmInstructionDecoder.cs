//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    
    public interface IAsmInstructionDecoder : IService
    {
        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        Option<AsmInstructionList> DecodeInstructions(in OperationBits src);        

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        Option<AsmInstructionList> DecodeInstructions(in LocatedCode src);  

        void DecodeInstructions(in LocatedCode src, Func<Instruction,bool> f);                      
    }
}