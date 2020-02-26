//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;

    using Z0.Asm;

    /// <summary>
    /// Defines service contract for the decoding phase of the asm capture workflow
    /// </summary>
    public interface IAsmDecoder : IAsmService
    {
        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        AsmInstructionList DecodeInstructions(AsmCode src);

        /// <summary>
        /// Decodes a function from a native capture
        /// </summary>
        /// <param name="src">The cource capture</param>
        AsmFunction DecodeFunction(CapturedMember src);    

        AsmFunction DecodeFunction(OpDescriptor op, CaptureSummary summary);        
    }
}