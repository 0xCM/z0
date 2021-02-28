//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines service contract for asm text formatting support
    /// </summary>
    public interface IAsmFormatter
    {
        /// <summary>
        /// The configuration used when rendering the formatted text
        /// </summary>
        AsmFormatConfig Config {get;}

        /// <summary>
        /// Creates a detailed presentation of decoded x86 asm data per the accompanying configuration spec
        /// </summary>
        /// <param name="src">The function to render as asm text</param>
        string Format(AsmRoutine src);

        /// <summary>
        /// Formats a single instruction
        /// </summary>
        /// <param name="@base">The base address to which the instruction is relative</param>
        /// <param name="src">The source instruction</param>
        string Format(in MemoryAddress @base, in AsmInstructionSummary src);

        /// <summary>
        /// Renders a routine to a caller-supplied buffer
        /// </summary>
        /// <param name="src">The source routine</param>
        /// <param name="dst">The target buffer</param>
        void Render(in AsmRoutine src, ITextBuffer dst);

        /// <summary>
        /// Renders a routine sequence to a caller-supplied buffer
        /// </summary>
        /// <param name="src">The source routines</param>
        /// <param name="dst">The target buffer</param>
        void Render(in AsmRoutines src, ITextBuffer dst);
    }
}