//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;

    /// <summary>
    /// Defines service contract for asm text formatting support
    /// </summary>
    public interface IAsmFormatter : IAsmService
    {
        /// <summary>
        /// The configuration used when rendering the formatted text
        /// </summary>
        AsmFormatConfig Config {get;}        
        
        /// <summary>
        /// Creates a detailed presentation of decoded x86 asm data per the accompanying configuration spec
        /// </summary>
        /// <param name="src">The function to render as asm text</param>
        string FormatFunction(AsmFunction src);        

        /// <summary>
        /// Formats a single instruction
        /// </summary>
        /// <param name="@base">The base address to which the instruction is relative</param>
        /// <param name="src">The source instruction</param>
        string FormatInstruction(in MemoryAddress @base, in AsmInstructionInfo src);    

        /// <summary>
        /// Formats the instruction in the source and returns a line for each and every one
        /// </summary>
        /// <param name="src">The source function</param>
        ReadOnlySpan<string> FormatLines(AsmFunction src);     

        /// <summary>
        /// Formats the instruction in the source and returns a line for each and every one
        /// </summary>
        /// <param name="src">The source function</param>
        ReadOnlySpan<string> FormatLines(AsmInstructionList src);               
    }
}