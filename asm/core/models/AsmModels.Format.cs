//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
     
    using static Core;

    partial class AsmModels
    {
        /// <summary>
        /// Formats a single instruction
        /// </summary>
        /// <param name="src">The instruction description</param>
        /// <param name="@base">The base address</param>
        /// <param name="config">An optional format configuration</param>
        [MethodImpl(Inline)]
        public static string FormatAsmLine(this AsmInstructionInfo src, in MemoryAddress @base, AsmFormatConfig config = null)
            => FormatInstruction(config ?? DefaultConfig, @base, src);

        /// <summary>
        /// Formats a contiguous sequence of instructions defined in an instruction list
        /// </summary>
        /// <param name="src">The instruction source</param>
        /// <param name="config">An optional format configuration</param>
        public static ReadOnlySpan<string> FormatAsmLines(this AsmInstructionList src, AsmFormatConfig config = null)
        {
            if(src.Length == 0)
                return default;

            var descriptions = src.DescribeInstructions();
            var lines = new List<string>();
            var @base = src[0].IP;
            for(var i = 0; i< descriptions.Length; i++)
                lines.Add(FormatInstruction(config ?? DefaultConfig, @base, descriptions[i]));
            return lines.ToArray();
        }
     
        public static string Format(this AsmFunctionList src)
        {
            var dst = text.factory.Builder();
            for(var i=0; i<src.Content.Length; i++)
            {
                dst.Append(src.Content[i].FormatAsmLines().Concat());
                dst.AppendLine(text.pagebreak);
            }
            return dst.ToString();
        }

        /// <summary>
        /// Formats the instructions in a function
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="config">An optional format configuration</param>
        public static ReadOnlySpan<string> FormatAsmLines(this AsmFunction src, AsmFormatConfig config = null)
        {
            var descriptions = src.DescribeInstructions();
            var lines = new List<string>();
            for(var i = 0; i< descriptions.Length; i++)
                lines.Add(FormatInstruction(config ?? DefaultConfig, src.BaseAddress, descriptions[i]));
            return lines.ToArray();
        }    
    
        [MethodImpl(Inline)]
        static string Comment(string text)
            =>  $"; {text}";

        static string Format(AsmInstructionCode src, AsmFormatConfig fmt)
            => $"{src.Definition}{fmt.FieldDelimiter}{src.OpCode}";

        static string FormatLineLabel(ulong src)
            => text.concat(src.FormatSmallHex(), HexSpecs.PostSpec, text.space());

        static string FormatInstruction(AsmFormatConfig config, in MemoryAddress @base, AsmInstructionInfo src)
        {
            var description = text.factory.Builder();
            var absolute = @base + (MemoryAddress)src.Offset;  
            description.Append(text.concat(FormatLineLabel(src.Offset), src.AsmContent.PadRight(config.InstructionPad, text.space())));
            description.Append(Comment(Format(src.Spec, config)));
            description.Append(text.concat(config.FieldDelimiter,"encoded", text.bracket(src.Encoded.Length.ToString())));
            description.Append(text.embrace(src.Encoded.FormatHex(text.space(), true, false)));
            return description.ToString();
        }
    }
}