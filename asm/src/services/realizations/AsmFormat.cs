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

	using Iced.Intel;

    using static zfunc;


    public static class AsmFormat
    {
        public static string Comment(string text)
            =>  $"; {text}";

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public static string FormatDetail(this AsmFunction src, AsmFormatConfig fmt = null)
        {            
            var dst = text();
            fmt = fmt ?? AsmFormatConfig.Default;

            if(fmt.EmitFunctionDelimiter)
                dst.AppendLine(fmt.FunctionDelimiter);
            
            foreach(var line in src.FormatHeader(fmt))
                dst.AppendLine(line);            

            dst.AppendLine(src.FormatInstructionBlock(fmt));                
            return dst.ToString();
        }


        /// <summary>
        /// Formats the function body encoding as a comma-separated list of hex values
        /// </summary>
        /// <param name="src">The source function</param>
        public static string FormatNativeHex(this AsmCode src)
            => src.Encoded.FormatHex(AsciSym.Comma, true, true, true);

        public static ReadOnlySpan<string> FormatInstructions(this AsmFunction src, AsmFormatConfig fmt = null)
        {
            fmt = fmt ?? AsmFormatConfig.Default;         
            var lines = new List<string>();
            for(var i = 0; i< src.InstructionCount; i++)
                lines.Add(src.Instructions[i].FormatInstruction(fmt));
            return lines.ToArray();
        }    

        public static string FormatInstructionBlock(this AsmFunction src, AsmFormatConfig fmt = null)
            => src.FormatInstructions(fmt).Concat(AsciEscape.Eol);

        // public static ReadOnlySpan<string> FormatInstructions(this InstructionList src, ulong root, AsmFormatConfig fmt = null)
        // {
        //     fmt = fmt ?? AsmFormatConfig.Default;

        //     if(src.Count == 0)
        //         return ReadOnlySpan<string>.Empty;
                        
        //     var dst = new string[src.Count];
        //     var line = 0;
        //     var formatter = new MasmFormatter(MasmOptions);
        //     var sb = text();
        //     var writer = new StringWriter(sb);
        //     var output = new AsmOutput(writer, root);
        //     for(var i = 0; i < src.Count; line++, i++)
        //     {
        //         ref readonly var instruction = ref src[i];
        //         formatter.Format(in instruction, output);                    
        //         dst[i] = fmt.ShowLineAddresses ?  concat(instruction.FormatLineLabel(), sb.ToString()) :  sb.ToString();
        //         sb.Clear();
        //     }
        //     return dst;
        // }

        public static ReadOnlySpan<string> FormatInstructions(this InstructionBlock src, AsmFormatConfig fmt = null)
        {
            fmt = fmt ?? AsmFormatConfig.Default;

            if(src.InstructionCount == 0)
                return ReadOnlySpan<string>.Empty;
            
            var dst = new string[src.InstructionCount];
            var line = 0;
            var formatter = new MasmFormatter(MasmOptions);
            var sb = text();
            var writer = new StringWriter(sb);
            var output = new AsmOutput(writer, src.Origin.Start);
            for(var i = 0; i < src.InstructionCount; line++, i++)
            {
                ref readonly var instruction = ref src[i];
                formatter.Format(in instruction, output);                    
                dst[i] = fmt.ShowLineAddresses ?  concat(instruction.FormatLineLabel(), sb.ToString()) :  sb.ToString();
                sb.Clear();
            }
            return dst;
        }

        /// <summary>
        /// Formats a single instruction
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="pad">The minimum character width of the instruction content</param>
        static string FormatInstruction(this AsmInstructionInfo src, AsmFormatConfig fmt = null)
        {
            fmt = fmt ?? AsmFormatConfig.Default;

            var description = text();    
            description.Append(concat(src.Offset.FormatLineLabel(), src.AsmContent.PadRight(fmt.InstructionPad, space())));
            description.Append(Comment(src.Spec.Format(fmt)));
            description.Append(concat(fmt.InfoDelimiter,"encoded", bracket(src.Encoded.Length.ToString())));
            description.Append(embrace(src.Encoded.FormatHex(space(), true, false)));
            return description.ToString();
        }

        static string Format(this AsmMemInfo src, AsmFormatConfig fmt = null)
        {
            fmt = fmt ?? AsmFormatConfig.Default;

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
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="encoding">Specifies whether to include the encoded hex bytes</param>
        /// <param name="location">Specifies whether to include the assembly-relative function location address</param>
        static ReadOnlySpan<string> FormatHeader(this AsmFunction src, AsmFormatConfig fmt = null)
        {            
            var lines = new List<string>();
            var code = src.Code;
            var location = src.Location;
            fmt = fmt ?? AsmFormatConfig.Default;

            lines.Add(Comment($"{code.Label}")); 
            
            if(fmt.HeaderEncodingProp)           
                lines.Add(Comment(code.FormatEncodingProp()));
            
            if(fmt.HeaderLocation && fmt.HeaderEncoding)
                lines.Add(Comment(concat(location.FormatHeaderLocation(code.Id), " = ", embrace(code.FormatHeaderEncoding()))));
            else if(fmt.HeaderLocation)
                lines.Add(Comment(location.FormatHeaderLocation(code.Id)));
            else if(fmt.HeaderEncoding)
                lines.Add(Comment(embrace(code.FormatHeaderEncoding())));

            lines.Add(Comment($"Capture completion code, {src.TermCode}"));

            if(fmt.HeaderTimestamp)
                lines.Add(Comment(now().ToLexicalString()));
            
            return lines.ToArray();
        }

        static string FormatHeaderEncoding(this AsmCode src)
            => src.Encoded.FormatHexBytes(sep: space(), zpad:true, specifier:false);

        static string FormatEncodingProp(this AsmCode src)
        {
            var propdecl = $"static ReadOnlySpan<byte> {src.Id}_Bytes";
            var alloc = $"{propdecl} => new byte[{src.Encoded.Length}]";
            var data = embrace(src.FormatNativeHex());
            var content = items(alloc, data, AsciSym.Semicolon.ToString()).Concat();
            return content;
        }

        static string Format(this AsmInstructionCode src, AsmFormatConfig fmt)
            => $"{src.Definition}{fmt.InfoDelimiter}{src.OpCode}";

        static string Format(this AsmBranchInfo src)
            => src.Label;

        static string FormatLineLabel(this ulong src)
            => concat(src.FormatSmallHex(), Hex.PostSpec, space());

        static string FormatLineLabel(this ushort src)
            => ((ulong)src).FormatLineLabel();

        static string FormatLineLabel(this Instruction src)
            => src.IP.FormatLineLabel();

        static string FormatHeaderLocation(this MemoryRange src, Moniker id)
            => $"{id}{src.Format()}[{src.Length}]"; 

        static MasmFormatterOptions MasmOptions => new MasmFormatterOptions
        {
            DecimalDigitGroupSize = 4,
            BranchLeadingZeroes = false,
            HexDigitGroupSize = 4,
            UpperCaseRegisters = false, 
            LeadingZeroes = false,
            DisplInBrackets = true, 
            UpperCaseHex = false,
                       
        };

        /// <summary>
        /// Formats a single operand
        /// </summary>
        /// <param name="src">The source operand</param>
        static string Format(this AsmOperandInfo src)
        {
            var fmt = src.ImmInfo.Map(i => $"{i.Value.FormatAsmHex()}:{i.Label}", () => string.Empty);
            fmt += src.Register.Map(r => r.RegisterName, () => string.Empty);
            fmt += src.Memory.Map(r => r.Format(), () => string.Empty);
            fmt += src.Branch.Map(b => b.Format(), () => string.Empty);
            if(string.IsNullOrWhiteSpace(fmt))
                fmt = src.Kind.ToString();
            return fmt;   
        }

        /// <summary>
        /// Formats the operands contained in an instruction
        /// </summary>
        /// <param name="src">The instruction description</param>
        static string FormatOperands(this AsmInstructionInfo src)
        {
            var count = src.Operands.Length;
            if(count == 0)
                return string.Empty;

            var sb = text();   
            for(var i=0; i<src.Operands.Length; i++)
            {
                sb.Append(src.Operands[i].Format());
                if(i != src.Operands.Length - 1)
                    sb.Append(AsciSym.Comma);                            
            }
            return bracket(sb.ToString());
        }


        class AsmOutput : FormatterOutput
        {
            TextWriter Writer {get;}
            
            ulong BaseAddress {get;}

            public AsmOutput(TextWriter writer, ulong root)
            {
                this.Writer = writer;
                this.BaseAddress = root;
            }
            
            public override void Write(string text, FormatterOutputTextKind kind)
            {
                switch(kind)
                {
                    case FormatterOutputTextKind.LabelAddress:
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