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
    public interface IAsmFormatter
    {
        /// <summary>
        /// The configuration used when rendering the formatted text
        /// </summary>
        AsmFormatSpec Config {get;}        
        
        /// <summary>
        /// Creates a detailed presentation of decoded x86 asm data per the accompanying configuration spec
        /// </summary>
        /// <param name="src">The function to render as asm text</param>
        string FormatFunction(AsmRoutine src);        

        /// <summary>
        /// Formats a single instruction
        /// </summary>
        /// <param name="@base">The base address to which the instruction is relative</param>
        /// <param name="src">The source instruction</param>
        string FormatInstruction(in MemoryAddress @base, in AsmFxSummary src);    

        /// <summary>
        /// Formats the instruction in the source and returns a line for each and every one
        /// </summary>
        /// <param name="src">The source function</param>
        ReadOnlySpan<string> FormatLines(AsmRoutine src);     

        /// <summary>
        /// Formats the instruction in the source and returns a line for each and every one
        /// </summary>
        /// <param name="src">The source function</param>
        ReadOnlySpan<string> FormatLines(AsmFxList src);               
    }
}