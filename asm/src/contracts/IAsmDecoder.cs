//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;

    using Z0.Asm;

    public interface IAsmFunctionDecoder : IAsmService
    {        
        /// <summary>
        /// Decodes a function from a member capture
        /// </summary>
        /// <param name="src">The cource capture</param>
        AsmFunction DecodeFunction(CapturedMember member, bool emitcil = true);   

        /// <summary>
        /// Decodes a function from the parsed encoding package
        /// </summary>
        /// <param name="parsed">The parsed data</param>
        AsmFunction DecodeFunction(ParsedEncoding parsed);
    }

    public interface IAsmInstructionDecoder : IAsmService
    {
        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        AsmInstructionList DecodeInstructions(AsmCode src);        
    }

    /// <summary>
    /// Defines service contract for the decoding phase of the asm capture workflow
    /// </summary>
    public interface IAsmDecoder : IAsmFunctionDecoder, IAsmInstructionDecoder
    {

    }
}