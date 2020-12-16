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
        Option<AsmRoutine> Decode(ApiCaptureBlock src);

        bool Decode(ApiCaptureBlock src, out AsmRoutine dst);

        /// <summary>
        /// Decodes a function from member capture data
        /// </summary>
        /// <param name="src">The source data</param>
        Option<AsmRoutine> Decode(ApiMemberCode src);

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        Option<AsmFxList> Decode(CodeBlock src);

        Option<AsmInstructions> Decode(ApiCodeBlock src);

        Option<AsmRoutine> Decode(ApiCaptureBlock src, Action<Asm.Instruction> f);

        Option<AsmFxList> Decode(ApiCodeBlock src, Action<Instruction> f);

        Option<AsmFxList> Decode(CodeBlock src, Action<Instruction> f);

        Option<AsmInstructions> Decode(BinaryCode code, MemoryAddress @base);
    }
}