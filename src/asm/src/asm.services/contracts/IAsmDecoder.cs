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
        Option<IceInstructionList> Decode(CodeBlock src);

        Option<AsmInstructionBlock> Decode(ApiCodeBlock src);

        Option<AsmRoutine> Decode(ApiCaptureBlock src, Action<Asm.IceInstruction> f);

        Option<IceInstructionList> Decode(ApiCodeBlock src, Action<IceInstruction> f);

        Option<IceInstructionList> Decode(CodeBlock src, Action<IceInstruction> f);

        Option<AsmInstructionBlock> Decode(BinaryCode code, MemoryAddress @base);
    }
}