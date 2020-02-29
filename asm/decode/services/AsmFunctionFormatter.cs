//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static zfunc;
    using static AsmServiceMessages;

    using Iced = Iced.Intel;

    readonly struct AsmFunctionFormatter : IAsmFunctionFormatter, IAsmInstructionFormatter
    {        
        public AsmFormatConfig Config {get;}

        public IAsmContext Context {get;}
        
        [MethodImpl(Inline)]
        public static AsmFunctionFormatter BaseFormatter(IAsmContext context)
            => new AsmFunctionFormatter(context, context.AsmFormat);

        [MethodImpl(Inline)]
        public static IAsmFunctionFormatter Create(IAsmContext context, AsmFormatConfig config)
            => new AsmFunctionFormatter(context, config);

        AsmFunctionFormatter(IAsmContext context, AsmFormatConfig config)
        {
            this.Context = context;
            this.Config = config;
        }

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public string FormatDetail(AsmFunction src)
        {            
            var dst = text.factory.Builder();

            if(Config.EmitSectionDelimiter)
                dst.AppendLine(Config.SectionDelimiter);
            
            if(Config.EmitFunctionHeader)        
                foreach(var line in FormatHeader(src))
                    dst.AppendLine(line);            

            dst.AppendLine(FormatInstructions(src).Concat(AsciEscape.Eol));
            
            return dst.ToString();
        }

        ReadOnlySpan<string> FormatInstructions(AsmFunction src)
        {
            var descriptions = DescribeInstructions(src);
            var lines = new List<string>();
            for(var i = 0; i< descriptions.Length; i++)
                lines.Add(FormatInstruction(src.BaseAddress, descriptions[i]));
            return lines.ToArray();
        }    

        public ReadOnlySpan<string> FormatInstructions(Iced.InstructionList src, ulong @base)
        {            
            static string LineLabel(ulong src)
                => text.concat(src.FormatSmallHex(), Hex.PostSpec, text.space());
            
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

        AsmInstructionInfo[] DescribeInstructions(AsmFunction src)
        {
            var dst = new AsmInstructionInfo[src.InstructionCount];
            var offset = (ushort)0;

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src.Instructions[i];
                
                if(src.Code.Length < offset + instruction.ByteLength)
                    throw appFail(InstructionSizeMismatch(instruction.IP, offset, src.Code.Length, instruction.ByteLength));                
            
                dst[i] = instruction.SummarizeInstruction(src.Code.Data, instruction.FormattedInstruction, offset, src.Code.AddressRange.Start);
                offset += (ushort)instruction.ByteLength;
            }
            return dst;
        }

        /// <summary>
        /// Formats the function body encoding as a comma-separated list of hex values
        /// </summary>
        /// <param name="src">The source function</param>
        static string EmbraceHex(AsmCode src)
            => text.embrace(src.Bytes.FormatHexBytes(sep: AsciSym.Comma, uppercase:true));

        static string FormatEncodingProp(AsmCode src)
            => Comment($"static ReadOnlySpan<byte> {src.Id}_Bytes => new byte[{src.Data.Length}]{EmbraceHex(src)};");

        string FormatHeaderCode(AsmCode code)
        {
            var dataline = Comment(code.Id);
            if(Config.EmitFunctionOrigin)
                dataline += code.AddressRange.Format();

            dataline += text.bracket(code.AddressRange.Length);

            if(Config.EmitFunctionHeaderEncoding)
            {
                var formatter = HexFormatter.Define<byte>();
                var formatted = formatter.Format(code.Data, Config.FunctionHeaderEncodingFormat);                
                dataline += text.concat(text.spaced(AsciSym.Eq), text.embrace(formatted));
            }
            return dataline;
        }

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        ReadOnlySpan<string> FormatHeader(AsmFunction src)
        {            
            var lines = new List<string>();
            var label = Comment($"{src.Operation.Signature}, {src.Uri}");
            lines.Add(label); 
            
            if(Config.EmitEncodingProp)           
                lines.Add(FormatEncodingProp(src.Code));

            lines.Add(FormatHeaderCode(src.Code));
                
            if(Config.EmitCaptureTermCode)
            {
                var cidesc = string.Empty;
                if(Config.EmitCaptureTermCode)
                    cidesc += text.concat(nameof(src.TermCode), text.spaced(AsciSym.Eq), src.TermCode.ToString());

                lines.Add(Comment(cidesc));
            }

            if(Config.EmitFunctionTimestamp)
                lines.Add(Comment(now().ToLexicalString()));
            
            return lines.ToArray();
        }

        string Format(AsmInstructionCode src, AsmFormatConfig fmt)
            => $"{src.Definition}{fmt.FieldDelimiter}{src.OpCode}";

        static string FormatLineLabel(ulong src)
            => text.concat(src.FormatSmallHex(), Hex.PostSpec, text.space());

        public string FormatInstruction(in MemoryAddress @base, in AsmInstructionInfo src)
        {
            var description = text.factory.Builder();
            var absolute = @base + (MemoryAddress)src.Offset;  
            description.Append(text.concat(FormatLineLabel(src.Offset), src.AsmContent.PadRight(Config.InstructionPad, text.space())));
            description.Append(Comment(Format(src.Spec, Config)));
            description.Append(text.concat(Config.FieldDelimiter,"encoded", text.bracket(src.Encoded.Length.ToString())));
            description.Append(text.embrace(src.Encoded.FormatHex(text.space(), true, false)));
            return description.ToString();
        }

        [MethodImpl(Inline)]
        static string FormatLabelAddress(string text, ulong baseaddress)
            => Hex.parse(text).Map(address => (address - baseaddress).FormatSmallHex(true),  
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