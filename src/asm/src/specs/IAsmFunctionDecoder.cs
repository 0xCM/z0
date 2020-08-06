//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;

    /// <summary>
    /// Characterizes function-centric asm decoding operations
    /// </summary>
    public interface IAsmFunctionDecoder
    {        
        /// <summary>
        /// Decodes a function from member capture data
        /// </summary>
        /// <param name="src">The source data</param>
        Option<AsmFunction> Decode(CapturedCode src);       

        /// <summary>
        /// Decodes a fucntion for a parsed extract
        /// </summary>
        /// <param name="src">The source data</param>
        Option<AsmFunction> Decode(ParsedExtraction src);

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        Option<AsmInstructionList> Decode(LocatedCode src);      

        Option<AsmInstructions> Decode(IdentifiedCode src);

        Option<AsmFunction> Decode(ParsedExtraction src, Action<Instruction> f);
        
        Option<AsmInstructionList> Decode(LocatedCode src, Action<Instruction> f);                      
    }
}