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
    public interface IAsmDecoder
    {        
        /// <summary>
        /// Decodes a function from member capture data
        /// </summary>
        /// <param name="src">The source data</param>
        Option<AsmRoutine> Decode(CapturedCode src);       

        /// <summary>
        /// Decodes an asm routine from a parsed extract
        /// </summary>
        /// <param name="src">The source data</param>
        Option<AsmRoutine> Decode(ParsedExtraction src);

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        Option<AsmFxList> Decode(LocatedCode src);      

        Option<AsmInstructions> Decode(IdentifiedCode src);

        Option<AsmRoutine> Decode(ParsedExtraction src, Action<Instruction> f);
        
        Option<AsmFxList> Decode(LocatedCode src, Action<Instruction> f);                      
    }
}