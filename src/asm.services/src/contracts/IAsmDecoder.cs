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
        Option<AsmRoutine> Decode(ApiCapture src);

        bool Decode(ApiCapture src, out AsmRoutine dst);

        /// <summary>
        /// Decodes a function from member capture data
        /// </summary>
        /// <param name="src">The source data</param>
        Option<AsmRoutine> Decode(ApiMemberHex src);

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        Option<AsmFxList> Decode(BasedCodeBlock src);

        Option<AsmInstructions> Decode(ApiHex src);

        Option<AsmRoutine> Decode(ApiCapture src, Action<Asm.Instruction> f);

        Option<AsmFxList> Decode(ApiHex src, Action<Instruction> f);

        Option<AsmFxList> Decode(BasedCodeBlock src, Action<Instruction> f);
    }
}