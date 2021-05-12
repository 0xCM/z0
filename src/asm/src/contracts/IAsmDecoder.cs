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
        Index<IceInstruction> Decode(BinaryCode code, MemoryAddress @base);

        /// <summary>
        /// Decodes a function from member capture data
        /// </summary>
        /// <param name="src">The source data</param>
        Option<AsmRoutine> Decode(ApiCaptureBlock src);

        Outcome Decode(in ApiCodeBlock src, out AsmInstructionBlock dst);

        Outcome Decode(in CodeBlock src, out IceInstructionList dst);

        Outcome Decode(ApiCodeBlock src, Action<IceInstruction> f, out IceInstructionList dst);

        Outcome Decode(in ApiCaptureBlock src, out AsmRoutine dst);

        Outcome Decode(in ApiMemberCode src, out AsmRoutine dst);
    }
}