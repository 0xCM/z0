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
        Option<AsmRoutine> Decode(X86ApiCapture src);

        /// <summary>
        /// Decodes a function from member capture data
        /// </summary>
        /// <param name="src">The source data</param>
        Option<AsmRoutine> Decode(X86ApiMember src);

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        Option<AsmFxList> Decode(X86Code src);

        Option<AsmInstructions> Decode(X86UriHex src);

        Option<AsmRoutine> Decode(X86ApiCapture src, Action<Asm.Instruction> f);

        Option<AsmFxList> Decode(X86ApiCode src, Action<Instruction> f);

        Option<AsmFxList> Decode(X86UriHex src, Action<Instruction> f);

        Option<AsmFxList> Decode(X86Code src, Action<Instruction> f);
    }
}