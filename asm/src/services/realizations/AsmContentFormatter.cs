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

    using Z0.AsmSpecs;

    using static zfunc;
    using static AsmServiceMessages;

    using Iced = Iced.Intel;

    readonly struct AsmContentFormatter : IAsmContentFormatter, IIcedAsmFormatter
    {
        readonly AsmFormatConfig Config;
        
        [MethodImpl(Inline)]
        public static IIcedAsmFormatter BaseFormatter(AsmFormatConfig config)
            => new AsmContentFormatter(config);

        [MethodImpl(Inline)]
        public static IAsmContentFormatter Create(AsmFormatConfig config)
            => new AsmContentFormatter(config);
        
        AsmContentFormatter(AsmFormatConfig config)
        {
            this.Config = config;
        }
        
        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public string FormatDetail(AsmFunction src)
        {            
            var dst = text();

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
                lines.Add(FormatInstruction(descriptions[i]));
            return lines.ToArray();
        }    

        public ReadOnlySpan<string> CaptureBaseFormat(Iced.InstructionList src, ulong baseaddress)
        {            
            static string LineLabel(ulong src)
                => concat(src.FormatSmallHex(), Hex.PostSpec, space());
            
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
            var sb = text();
            var writer = new StringWriter(sb);
            var output = new AsmOutput(writer, baseaddress);
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
                    throw error(InstructionSizeMismatch(instruction.IP, offset, src.Code.Length, instruction.ByteLength));                
            
                dst[i] = instruction.SummarizeInstruction(src.Code.Encoded, instruction.FormattedInstruction, offset, src.Code.Origin.Start);
                offset += (ushort)instruction.ByteLength;
            }
            return dst;
        }

        static string FormatEncodingProp(AsmCode src)
            => Comment($"static ReadOnlySpan<byte> {src.Id}_Bytes => new byte[{src.Encoded.Length}]{embrace(src.FormatNativeHex())};");


        string FormatHeaderCode(AsmCode code)
        {
            var dataline = Comment(code.Id);
            if(Config.EmitFunctionOrigin)
                dataline += code.Origin.Format();

            dataline += bracket(code.Origin.Length);

            if(Config.EmitFunctionEncoding)
                dataline += concat(spaced(AsciSym.Eq), embrace(code.Encoded.FormatAsmHex()));            
            return dataline;
        }

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        ReadOnlySpan<string> FormatHeader(AsmFunction src)
        {            
            var lines = new List<string>();

            lines.Add(Comment($"{src.Label}")); 
            
            if(Config.EmitEncodingProp)           
                lines.Add(FormatEncodingProp(src.Code));

            lines.Add(FormatHeaderCode(src.Code));
                
            if(Config.EmitCaptureTermCode)
                lines.Add(Comment(concat("Capture completion code", spaced(AsciSym.Eq), src.TermCode.ToString())));

            if(Config.EmitFunctionTimestamp)
                lines.Add(Comment(now().ToLexicalString()));
            
            return lines.ToArray();
        }

        string Format(AsmInstructionCode src, AsmFormatConfig fmt)
            => $"{src.Definition}{fmt.FieldDelimiter}{src.OpCode}";

        static string FormatLineLabel(ulong src)
            => concat(src.FormatSmallHex(), Hex.PostSpec, space());

        static string FormatLineLabel(ushort src)
            => FormatLineLabel(((ulong)src));

        string FormatInstruction(AsmInstructionInfo src)
        {
            var description = text();    
            description.Append(concat(FormatLineLabel(src.Offset), src.AsmContent.PadRight(Config.InstructionPad, space())));
            description.Append(Comment(Format(src.Spec, Config)));
            description.Append(concat(Config.FieldDelimiter,"encoded", bracket(src.Encoded.Length.ToString())));
            description.Append(embrace(src.Encoded.FormatHex(space(), true, false)));
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

