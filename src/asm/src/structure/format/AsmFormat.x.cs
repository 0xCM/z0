//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    using static Seed;
    using static Memories;

    partial class XTend
    {
        /// <summary>
        /// Formats a single instruction
        /// </summary>
        /// <param name="src">The instruction description</param>
        /// <param name="@base">The base address</param>
        /// <param name="config">An optional format configuration</param>
        public static string FormatAsmLine(this AsmInstructionInfo src, in MemoryAddress @base, AsmFormatConfig config = null)
            => AsmFormat.render(src,@base,config);

        /// <summary>
        /// Formats a contiguous sequence of instructions defined in an instruction list
        /// </summary>
        /// <param name="src">The instruction source</param>
        /// <param name="config">An optional format configuration</param>
        public static ReadOnlySpan<string> FormatAsmLines(this AsmInstructionList src, AsmFormatConfig config = null)
            => AsmFormat.lines(src,config);

        /// <summary>
        /// Formats a function list
        /// </summary>
        /// <param name="src">The function source</param>
        public static string Format(this AsmFunctionList src)
            => AsmFormat.render(src);

        /// <summary>
        /// Formats the instructions in a function
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="config">An optional format configuration</param>
        public static ReadOnlySpan<string> FormatAsmLines(this AsmFunction src, AsmFormatConfig config = null)
            => AsmFormat.lines(src,config);
    }
}