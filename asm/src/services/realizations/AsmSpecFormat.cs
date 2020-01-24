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

    using static zfunc;
    using static AsmServiceMessages;

    using Iced = Iced.Intel;

    class AsmSpecFormatter : IAsmFormatter
    {
        static string Comment(string text)
            =>  $"; {text}";

        public static IAsmFormatter Create(AsmFormatConfig config = null)
            => new AsmSpecFormatter(config);
        
        AsmSpecFormatter(AsmFormatConfig config)
        {
            this.config = config ?? AsmFormatConfig.Default;
        }

        readonly AsmFormatConfig config;
        
        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public string FormatDetail(AsmSpecs.AsmFunction src)
        {            
            var dst = text();

            if(config.EmitFunctionDelimiter)
                dst.AppendLine(config.FunctionDelimiter);
            
            foreach(var line in FormatHeader(src,config))
                dst.AppendLine(line);            

            dst.Append(FormatInstructions(src).Concat(AsciEscape.Eol));
            
            return dst.ToString();
        }

        ReadOnlySpan<string> FormatInstructions(AsmSpecs.AsmFunction src)
        {
            var descriptions = DescribeInstructions(src);
            var lines = new List<string>();
            for(var i = 0; i< descriptions.Length; i++)
                lines.Add(FormatInstruction(descriptions[i]));
            return lines.ToArray();
        }    

        static string FormatLineLabel(Iced.Instruction src)
            => FormatLineLabel(src.IP);

        public static ReadOnlySpan<string> CaptureBaseFormat(Iced.InstructionList src, ulong root, AsmFormatConfig fmt)
        {
            fmt = fmt ?? AsmFormatConfig.Default;

            if(src.Count == 0)
                return ReadOnlySpan<string>.Empty;
                        
            var dst = new string[src.Count];
            var line = 0;
            var formatter = new Iced.MasmFormatter(MasmOptions);
            var sb = text();
            var writer = new StringWriter(sb);
            var output = new AsmOutput(writer, root);
            for(var i = 0; i < src.Count; line++, i++)
            {
                ref readonly var instruction = ref src[i];
                formatter.Format(in instruction, output);                    
                dst[i] = fmt.ShowLineAddresses ?  concat(FormatLineLabel(instruction), sb.ToString()) :  sb.ToString();
                sb.Clear();
            }
            return dst;
        }

        static AsmInstructionInfo[] DescribeInstructions(AsmSpecs.AsmFunction src)
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

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="encoding">Specifies whether to include the encoded hex bytes</param>
        /// <param name="location">Specifies whether to include the assembly-relative function location address</param>
        static ReadOnlySpan<string> FormatHeader(AsmSpecs.AsmFunction src, AsmFormatConfig fmt = null)
        {            
            var lines = new List<string>();
            var code = src.Code;
            var location = src.Location;
            fmt = fmt ?? AsmFormatConfig.Default;

            lines.Add(Comment($"{code.Label}")); 
            
            if(fmt.HeaderEncodingProp)           
                lines.Add(Comment(FormatEncodingProp(code)));
            
            if(fmt.HeaderLocation && fmt.HeaderEncoding)
                lines.Add(Comment(concat(FormatHeaderLocation(location,code.Id), " = ", embrace(FormatHeaderEncoding(code)))));
            else if(fmt.HeaderLocation)
                lines.Add(Comment(FormatHeaderLocation(location,code.Id)));
            else if(fmt.HeaderEncoding)
                lines.Add(Comment(embrace(FormatHeaderEncoding(code))));

            lines.Add(Comment($"Capture completion code, {src.TermCode}"));

            if(fmt.HeaderTimestamp)
                lines.Add(Comment(now().ToLexicalString()));
            
            return lines.ToArray();
        }

        static string FormatHeaderEncoding(AsmCode src)
            => src.Encoded.FormatHexBytes(sep: space(), zpad:true, specifier:false);

        static string FormatHeaderLocation( MemoryRange src, Moniker id)
            => $"{id}{src.Format()}[{src.Length}]"; 

        static string FormatEncodingProp(AsmCode src)
        {
            var propdecl = $"static ReadOnlySpan<byte> {src.Id}_Bytes";
            var alloc = $"{propdecl} => new byte[{src.Encoded.Length}]";
            var data = embrace(src.FormatNativeHex());
            var content = items(alloc, data, AsciSym.Semicolon.ToString()).Concat();
            return content;
        }

        static string Format(AsmInstructionCode src, AsmFormatConfig fmt)
            => $"{src.Definition}{fmt.InfoDelimiter}{src.OpCode}";

        static string Format(AsmBranchInfo src)
            => src.Label;

        static string FormatLineLabel(ulong src)
            => concat(src.FormatSmallHex(), Hex.PostSpec, space());

        static string FormatLineLabel(ushort src)
            => FormatLineLabel(((ulong)src));

        static string FormatLineLabel(AsmSpecs.Instruction src)
            => FormatLineLabel(src.IP);

        string FormatInstruction(AsmInstructionInfo src)
        {
            var description = text();    
            description.Append(concat(FormatLineLabel(src.Offset), src.AsmContent.PadRight(config.InstructionPad, space())));
            description.Append(Comment(Format(src.Spec, config)));
            description.Append(concat(config.InfoDelimiter,"encoded", bracket(src.Encoded.Length.ToString())));
            description.Append(embrace(src.Encoded.FormatHex(space(), true, false)));
            return description.ToString();
        }

        string Format(AsmMemInfo src)
        {

            var items = new List<(string value, string type)>();
        
            if(src.Address != 0)
                items.Add((src.Address.FormatHex(false,true, false, false),"address"));
            
            if(src.Size != string.Empty)
                items.Add((src.Size, string.Empty));
            if(!string.IsNullOrWhiteSpace(src.BaseRegister))
                items.Add((src.BaseRegister,"br"));
            if(!string.IsNullOrWhiteSpace(src.SegmentPrefix))
                items.Add((src.SegmentPrefix,""));
            if(!string.IsNullOrWhiteSpace(src.SegmentRegister))
                items.Add((src.SegmentPrefix,"sr"));

            var sb = text();
            for(var i=0; i<items.Count; i++)
            {
                var item = items[i];
                if(item.type == string.Empty)
                    sb.Append(item.value);
                else
                    sb.Append($"{item.value}:{item.type}");
                if(i != items.Count - 1)
                    sb.Append(AsciSym.Comma);
            
            }
            return "mem" + parenthetical(sb.ToString());
        }

        /// <summary>
        /// Formats a single operand
        /// </summary>
        /// <param name="src">The source operand</param>
        string Format(AsmOperandInfo src)
        {
            var fmt = src.ImmInfo.Map(i => $"{i.Value.FormatAsmHex()}:{i.Label}", () => string.Empty);
            fmt += src.Register.Map(r => r.RegisterName, () => string.Empty);
            fmt += src.Memory.Map(r => Format(r), () => string.Empty);
            fmt += src.Branch.Map(b => Format(b), () => string.Empty);
            if(string.IsNullOrWhiteSpace(fmt))
                fmt = src.Kind.ToString();
            return fmt;   
        }

        /// <summary>
        /// Formats the operands contained in an instruction
        /// </summary>
        /// <param name="src">The instruction description</param>
        string FormatOperands(AsmInstructionInfo src)
        {
            var count = src.Operands.Length;
            if(count == 0)
                return string.Empty;

            var sb = text();   
            for(var i=0; i<src.Operands.Length; i++)
            {
                sb.Append(Format(src.Operands[i]));
                if(i != src.Operands.Length - 1)
                    sb.Append(AsciSym.Comma);                            
            }
            return bracket(sb.ToString());
        }


        static Iced.MasmFormatterOptions MasmOptions => new Iced.MasmFormatterOptions
        {
            DecimalDigitGroupSize = 4,
            BranchLeadingZeroes = false,
            HexDigitGroupSize = 4,
            UpperCaseRegisters = false, 
            LeadingZeroes = false,
            DisplInBrackets = true, 
            UpperCaseHex = false,
                       
        };

        class AsmOutput : Iced.FormatterOutput
        {
            TextWriter Writer {get;}
            
            ulong BaseAddress {get;}

            public AsmOutput(TextWriter writer, ulong root)
            {
                this.Writer = writer;
                this.BaseAddress = root;
            }
            
            public override void Write(string text, Iced.FormatterOutputTextKind kind)
            {
                switch(kind)
                {
                    case Iced.FormatterOutputTextKind.LabelAddress:
                        Hex.parse(text).OnSome(address => Writer.Write((address - BaseAddress).FormatSmallHex(true)))
                                        .OnNone(() => Writer.Write($"{text}{AsciSym.Question}"));
                    break;
                    default:
                        Writer.Write(text);    
                    break;
                }
            }                
        }


    }
}

