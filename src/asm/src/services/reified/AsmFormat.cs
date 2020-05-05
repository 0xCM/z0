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

    public readonly struct AsmFormat
    {
        const char blank = Chars.Space;

        [MethodImpl(Inline)]
        public static string comment(string text)
            =>  $"; {text}";

        public static string render(AsmInstructionCode src, in AsmFormatSpec fmt)
            => $"{src.Definition}{fmt.FieldDelimiter}{src.OpCode}";

        /// <summary>
        /// Formats a line label
        /// </summary>
        /// <param name="src">The relative line location</param>
        public static string label(ulong src)
            => text.concat(src.FormatSmallHex(), HexSpecs.PostSpec, blank);

        public static string render(in MemoryAddress @base, in AsmInstructionSummary src, in AsmFormatSpec config)
        {
            var description = text.build();
            var absolute = @base + (MemoryAddress)src.Offset;  
            description.Append(text.concat(label(src.Offset), src.AsmContent.PadRight(config.InstructionPad, blank)));
            description.Append(comment(render(src.Spec, config)));
            description.Append(text.concat(config.FieldDelimiter,"encoded", text.bracket(src.Encoded.Length.ToString())));
            description.Append(text.embrace(src.Encoded.FormatHexBytes(blank, true, false)));
            return description.ToString();
        }

        public static string render(in MemoryAddress @base, in AsmInstructionSummary src)
            => render(@base, src, AsmFormatSpec.Default);

        /// <summary>
        /// Formats the instructions in a function
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="config">An optional format configuration</param>
        public static ReadOnlySpan<string> lines(in AsmFunction src, in AsmFormatSpec? cfg = null)
        {
            var descriptions = AsmSemantic.Service.Summarize(src);
            var count = descriptions.Length;
            var lines = Spans.alloc<string>(count);
            var config = cfg ?? AsmFormatSpec.Default;
            for(var i = 0; i< count; i++)
                lines[i]= render(src.BaseAddress, descriptions[i], config);
            return lines;
        }    

        /// <summary>
        /// Formats a contiguous sequence of instructions defined in an instruction list
        /// </summary>
        /// <param name="src">The instruction source</param>
        /// <param name="config">An optional format configuration</param>
        public static ReadOnlySpan<string> lines(in AsmInstructionList src, in AsmFormatSpec? cfg = null)
        {
            if(src.Length == 0)
                return default;

            var config = cfg ?? AsmFormatSpec.Default;
            var descriptions =  AsmSemantic.Service.Summarize(src);
            var lines = Spans.alloc<string>(src.Length);
            var @base = src[0].IP;
            for(var i=0; i< src.Length; i++)
                lines[i] = render(@base, descriptions[i], config);
            return lines;
        }

        /// <summary>
        /// Formats source bits on a single line intended for emission in the function header
        /// </summary>
        /// <param name="src">The source bits</param>
        public static string header(LocatedCode src, OpIdentity id)
            => comment(ByteSpanProperty.Define(id.ToLegalIdentifier(), src).Format());

        public static string render(in AsmFunctionList src)
        {
            var dst = text.factory.Builder();
            for(var i=0; i<src.Content.Length; i++)
            {
                dst.Append(lines(src.Content[i]).Concat());
                dst.AppendLine(text.PageBreak);
            }
            return dst.ToString();
        }
    
        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public static string render(AsmFunction src, in AsmFormatSpec? cfg = null)
        {            
            var config = cfg ?? AsmFormatSpec.Default;
            var dst = text.factory.Builder();

            if(config.EmitSectionDelimiter)
                dst.AppendLine(config.SectionDelimiter);
            
            if(config.EmitFunctionHeader)        
                foreach(var line in header(src, config))
                    dst.AppendLine(line);            

            dst.AppendLine(lines(src, config).Concat(Chars.Eol));            
            
            return dst.ToString();
        }


        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        public static ReadOnlySpan<string> header(AsmFunction src, in AsmFormatSpec? cfg = null)
        {            
            var config = cfg ?? AsmFormatSpec.Default;

            var lines = new List<string>();
            lines.Add(comment($"{src.OpSig}, {src.Uri}")); 
            
            if(config.EmitFunctionHeaderEncoding)
                lines.Add(AsmFormat.header(src.Code.Encoded, src.OpId));
            else
                lines.Add(comment(src.Code.Uri.OpId));

            if(config.EmitLocation)
                lines.Add(comment(text.concat("Base", text.spaced(Chars.Eq), src.Code.Address)));
                
            if(config.EmitCaptureTermCode)
            {
                var cidesc = string.Empty;
                if(config.EmitCaptureTermCode)
                    cidesc += text.concat(nameof(src.TermCode), text.spaced(Chars.Eq), src.TermCode.ToString());

                lines.Add(comment(cidesc));
            }

            if(config.EmitFunctionTimestamp)
                lines.Add(comment(time.now().ToLexicalString()));
            
            return lines.ToArray();
        }

        [MethodImpl(Inline)]
        public static string label(string text, ulong baseaddress)
            => HexParsers.Scalar.Parse(text).ToOption().Map(address => (address - baseaddress).FormatSmallHex(true),  
                    () => $"{text}?");
    }
}