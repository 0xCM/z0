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
        /// Decodes a function from the parsed encoding package
        /// </summary>
        /// <param name="src">The source data</param>
        Option<AsmFunction> Decode(ParsedMember src);

        /// <summary>
        /// Decodes a function from member capture data
        /// </summary>
        /// <param name="src">The source data</param>
        Option<AsmFunction> Decode(MemberCapture src);       

        /// <summary>
        /// Decodes a fucntion for a parsed extract
        /// </summary>
        /// <param name="src">The source data</param>
        Option<AsmFunction> Decode(ParsedMemberExtract src);
    }
}