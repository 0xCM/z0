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

    public static class AsmFormat
    {
        /// <summary>
        /// Formats an instruction
        /// </summary>
        /// <param name="config">The format configuration</param>
        /// <param name="@base">The base address</param>
        /// <param name="src">The instruction description</param>
        public static string render(in MemoryAddress @base, AsmInstructionInfo src, AsmFormatConfig fmt = null)        
        {
            var config = fmt ?? AsmFormatConfig.New;
            var description = text.factory.Builder();
            var absolute = @base + (MemoryAddress)src.Offset;  
            description.Append(text.concat(label(src.Offset), src.AsmContent.PadRight(config.InstructionPad, text.space())));
            description.Append(comment(render(src.Spec, config)));
            description.Append(text.concat(config.FieldDelimiter,"encoded", text.bracket(src.Encoded.Length.ToString())));
            description.Append(text.embrace(src.Encoded.FormatHexBytes(text.space(), true, false)));
            return description.ToString();
        }

        /// <summary>
        /// Formats an instruction
        /// </summary>
        /// <param name="src">The instruction description</param>
        /// <param name="@base">The base address</param>
        /// <param name="config">An optional format configuration</param>
        [MethodImpl(Inline)]
        public static string render(AsmInstructionInfo src, in MemoryAddress @base, AsmFormatConfig config = null)
            => render(@base, src, config);

        /// <summary>
        /// Formats the instructions in a function
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="config">An optional format configuration</param>
        public static ReadOnlySpan<string> lines(in AsmFunction src, AsmFormatConfig config = null)
        {
            var descriptions = src.DescribeInstructions();
            var lines = new List<string>();
            for(var i = 0; i< descriptions.Length; i++)
                lines.Add(render(src.BaseAddress, descriptions[i], config));
            return lines.ToArray();
        }    

        /// <summary>
        /// Formats a contiguous sequence of instructions defined in an instruction list
        /// </summary>
        /// <param name="src">The instruction source</param>
        /// <param name="config">An optional format configuration</param>
        public static ReadOnlySpan<string> lines(AsmInstructionList src, AsmFormatConfig config = null)
        {
            if(src.Length == 0)
                return default;

            var descriptions = src.DescribeInstructions();
            var lines = new List<string>();
            var @base = src[0].IP;
            for(var i = 0; i< descriptions.Length; i++)
                lines.Add(render(@base, descriptions[i], config));
            return lines.ToArray();
        }

        public static string render(in AsmFunctionList src)
        {
            var dst = text.factory.Builder();
            for(var i=0; i<src.Content.Length; i++)
            {
                dst.Append(lines(src.Content[i]).Concat());
                dst.AppendLine(text.pagebreak);
            }
            return dst.ToString();
        }

        [MethodImpl(Inline)]
        public static string comment(string text)
            =>  $"; {text}";

        public static string render(AsmInstructionCode src, AsmFormatConfig fmt)
            => $"{src.Definition}{fmt.FieldDelimiter}{src.OpCode}";

        /// <summary>
        /// Formats a line label
        /// </summary>
        /// <param name="src">The relative line location</param>
        public static string label(ulong src)
            => text.concat(src.FormatSmallHex(), HexSpecs.PostSpec, text.space());
    
        public static string render(MemorySize src)
            => src switch {
                MemorySize.Int8 => "8i",
                MemorySize.Int16 => "16i",
                MemorySize.Int32 => "32i",
                MemorySize.Int64 => "64i",
                MemorySize.UInt8 => "8u",
                MemorySize.UInt16 => "16u",
                MemorySize.UInt32 => "32u",
                MemorySize.UInt64 => "64u",
                _   => src.ToString()
            };
    }

	partial class XTend
    {
        public static string Format(this MemorySize src)
            => AsmFormat.render(src);
    }
}