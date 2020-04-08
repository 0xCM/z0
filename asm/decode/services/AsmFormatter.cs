//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Core;

    using Iced = Iced.Intel;


    readonly struct AsmFormatter : IAsmFormatter
    {        
        public AsmFormatConfig Config {get;}
        
        [MethodImpl(Inline)]
        public static AsmFormatter Internal(AsmFormatConfig config)
            => new AsmFormatter(config);

        [MethodImpl(Inline)]
        public static IAsmFormatter Create(IContext context, AsmFormatConfig config)
            => new AsmFormatter(config);

        AsmFormatter(AsmFormatConfig config)
        {
            this.Config = config;
        }

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public string FormatFunction(AsmFunction src)
        {            
            var dst = text.factory.Builder();

            if(Config.EmitSectionDelimiter)
                dst.AppendLine(Config.SectionDelimiter);
            
            if(Config.EmitFunctionHeader)        
                foreach(var line in FormatHeader(src))
                    dst.AppendLine(line);            

            dst.AppendLine(FormatLines(src).Concat(Chars.Eol));
            
            return dst.ToString();
        }

        public string FormatInstruction(in MemoryAddress @base, in AsmInstructionInfo src)
        {
            var description = text.build();
            var absolute = @base + (MemoryAddress)src.Offset;  
            description.Append(text.concat(FormatLineLabel(src.Offset), src.AsmContent.PadRight(Config.InstructionPad, text.space())));
            description.Append(Comment(Format(src.Spec, Config)));
            description.Append(text.concat(Config.FieldDelimiter,"encoded", text.bracket(src.Encoded.Length.ToString())));
            description.Append(text.embrace(src.Encoded.FormatHexBytes(text.space(), true, false)));
            return description.ToString();
        }

        public ReadOnlySpan<string> FormatLines(AsmInstructionList src)
        {
            if(src.Length == 0)
                return default;
            
            var descriptions = src.DescribeInstructions();
            var lines = Spans.alloc<string>(src.Length);
            var @base = src[0].IP;
            for(var i=0; i< src.Length; i++)
                lines[i] = FormatInstruction(@base, descriptions[i]);
            return lines;
        }

        public ReadOnlySpan<string> FormatLines(AsmFunction src)
        {
            var descriptions = src.DescribeInstructions();
            var lines = new List<string>();
            for(var i = 0; i< descriptions.Length; i++)
                lines.Add(FormatInstruction(src.BaseAddress, descriptions[i]));
            return lines.ToArray();
        }    

        public ReadOnlySpan<string> FormatInstructions(Iced.InstructionList src, ulong @base)
        {            
            static string LineLabel(ulong src)
                => text.concat(src.FormatSmallHex(), HexSpecs.PostSpec, text.space());
            
            if(src.Count == 0)
                return ReadOnlySpan<string>.Empty;

            var formatter = new Iced.MasmFormatter(new Iced.MasmFormatterOptions
                {
                    DecimalDigitGroupSize = 4,
                    BranchLeadingZeroes = false,
                    HexDigitGroupSize = 4,
                    UpperCaseRegisters = false, 
                    LeadingZeroes = false,
                    DisplInBrackets = true, 
                    UpperCaseHex = false,
                    RipRelativeAddresses = true,
                    SignedMemoryDisplacements = true,
                            
                });                

            var dst = new string[src.Count];
            var sb = text.factory.Builder();
            var writer = new StringWriter(sb);
            var output = new AsmOutput(writer, @base);
            for(var i = 0; i < src.Count; i++)
            {
                ref readonly var instruction = ref src[i];
                formatter.Format(in instruction, output);                    
                dst[i] = sb.ToString();
                sb.Clear();
            }
            return dst;
        }

        [MethodImpl(Inline)]
        static string Comment(string text)
            =>  $"; {text}";

        string FormatHeaderCode(AsmCode code)
        {
            if(Config.EmitFunctionHeaderEncoding)
                return Comment(ByteSpanProperty.Define(code.Id, code.Data).Format());
            else
                return Comment(code.Id);
        }

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        ReadOnlySpan<string> FormatHeader(AsmFunction src)
        {            
            var lines = new List<string>();
            var label = Comment($"{src.OpSig}, {src.Uri}");
            lines.Add(label); 
            
            lines.Add(FormatHeaderCode(src.Code));

            if(Config.EmitLocation)
                lines.Add(Comment(text.concat(nameof(src.Code.Location), text.spaced(Chars.Eq), src.Code.Location.Format())));
                
            if(Config.EmitCaptureTermCode)
            {
                var cidesc = string.Empty;
                if(Config.EmitCaptureTermCode)
                    cidesc += text.concat(nameof(src.TermCode), text.spaced(Chars.Eq), src.TermCode.ToString());

                lines.Add(Comment(cidesc));
            }

            if(Config.EmitFunctionTimestamp)
                lines.Add(Comment(time.now().ToLexicalString()));
            
            return lines.ToArray();
        }

        string Format(AsmInstructionCode src, AsmFormatConfig fmt)
            => $"{src.Definition}{fmt.FieldDelimiter}{src.OpCode}";

        static string FormatLineLabel(ulong src)
            => text.concat(src.FormatSmallHex(), HexSpecs.PostSpec, text.space());

        [MethodImpl(Inline)]
        static string FormatLabelAddress(string text, ulong baseaddress)
            => HexParsers.Numeric.Parse(text).ToOption().Map(address => (address - baseaddress).FormatSmallHex(true),  
                    () => $"{text}?");

        class AsmOutput : Iced.FormatterOutput
        {
            readonly TextWriter Writer;
            
            readonly ulong BaseAddress;

            public AsmOutput(TextWriter writer, ulong baseaddress)
            {
                this.Writer = writer;
                this.BaseAddress = baseaddress;
            }
            
            public override void Write(string text, Iced.FormatterOutputTextKind kind)
            {
                switch(kind)
                {
                    case Iced.FormatterOutputTextKind.LabelAddress:
                        Writer.Write(FormatLabelAddress(text, BaseAddress));
                    break;
                    default:
                        Writer.Write(text);    
                    break;
                }
            }                
        }
    }
}