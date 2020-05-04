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
    public interface IAsmFunctionDecoder : IAsmInstructionDecoder
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
        Option<AsmFunction> Decode(ParsedMember src);

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        Option<AsmInstructionList> Decode(LocatedCode src);      

        Option<AsmFunction> Decode(ParsedMember src, Action<Asm.Instruction> f);
        
        Option<AsmInstructionList> Decode(LocatedCode src, Action<Instruction> f);                      

        Option<AsmInstructions> Decode(UriBits src);

    }
}