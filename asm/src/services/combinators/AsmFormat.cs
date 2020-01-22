//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
	using Iced.Intel;
    using System.IO;

    using static zfunc;

    public static class AsmFormat
    {
        public static string Comment(string text)
            =>  $"; {text}";

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="pad">The padding between each instruction and associated commentary</param>
        public static string FormatDetail(this AsmFunction src)
            => src.FormatDetail(AsmFormatConfig.Default); 

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public static string FormatDetail(this AsmFunction src, AsmFormatConfig fmt)
        {            
            var detail = text();

            if(fmt.EmitFunctionDelimiter)
                detail.AppendLine(fmt.FunctionDelimiter);
            
            foreach(var line in src.FormatHeader(fmt))
                detail.AppendLine(line);            

            detail.AppendLine(src.FormatInstructionBlock(fmt));                
            return detail.ToString();
        }

        /// <summary>
        /// Formats the function body encoding as a comma-separated list of hex values
        /// </summary>
        /// <param name="src">The source function</param>
        public static string FormatNativeHex(this AsmCode src)
            => src.Encoded.FormatHex(AsciSym.Comma, true, true, true);

        public static string FormatInstructionLines(this InstructionBlock src, AsmFormatConfig config = null)
            => src.FormatInstructions(config ?? AsmFormatConfig.Default).FormatLines();

        public static string FormatInstructionLines(this AsmFunction src, AsmFormatConfig config = null)
            => src.FormatInstructionBlock(config ?? AsmFormatConfig.Default);

        public static ReadOnlySpan<string> FormatInstructions(this InstructionBlock src, AsmFormatConfig config)
        {
            if(src.InstructionCount == 0)
                return ReadOnlySpan<string>.Empty;
            
            var line = 0;
            Span<string> dst = new string[src.InstructionCount];

            var formatter = new MasmFormatter(MasmOptions);
            var sb = text();
            var writer = new StringWriter(sb);
            var output = new AsmOutput(writer, src.Location.Start);
            for(var i = 0; i < src.InstructionCount; line++, i++)
            {
                ref readonly var instruction = ref src[i];
                formatter.Format(in instruction, output);                    
                dst[i] = config.ShowLineAddresses ?  concat(instruction.FormatLineLabel(), sb.ToString()) :  sb.ToString();
                sb.Clear();
            }
            return dst;
        }

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="encoding">Specifies whether to include the encoded hex bytes</param>
        /// <param name="location">Specifies whether to include the assembly-relative function location address</param>
        static ReadOnlySpan<string> FormatHeader(this AsmFunction src, AsmFormatConfig fmt)
        {            
            var lines = new List<string>();
            var code = src.Code;
            var location = src.Location;

            lines.Add(Comment($"{code.Label}")); 
            
            if(fmt.HeaderEncodingProp)           
                lines.Add(Comment(code.FormatEncodingProp()));
            
            if(fmt.HeaderLocation && fmt.HeaderEncoding)
                lines.Add(Comment(concat(location.FormatHeaderLocation(code.Id), " = ", embrace(code.FormatHeaderEncoding()))));
            else if(fmt.HeaderLocation)
                lines.Add(Comment(location.FormatHeaderLocation(code.Id)));
            else if(fmt.HeaderEncoding)
                lines.Add(Comment(embrace(code.FormatHeaderEncoding())));

            lines.Add(Comment($"Capture completion code, {src.TermReason}"));

            if(fmt.HeaderTimestamp)
                lines.Add(Comment(now().ToLexicalString()));
            
            return lines.ToArray();
        }

        /// <summary>
        /// Formats a single instruction
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="pad">The minimum character width of the instruction content</param>
        static string FormatInstruction(this AsmInstructionInfo src, AsmFormatConfig fmt)
        {
            var description = text();    
            description.Append(concat(src.Offset.FormatLineLabel(), src.AsmContent.PadRight(fmt.InstructionPad, space())));
            description.Append(Comment(src.Spec.Format(fmt)));
            description.Append(concat(fmt.InfoDelimiter,"encoded", bracket(src.Encoded.Length.ToString())));
            description.Append(embrace(src.Encoded.FormatHex(space(), true, false)));
            return description.ToString();
        }

        static string FormatInstructionBlock(this AsmFunction src, AsmFormatConfig fmt)
        {
            var description = text();            
            for(var i = 0; i< src.InstructionCount; i++)
            {
                var instruction = src.Instructions[i].FormatInstruction(fmt);
                if(i != src.InstructionCount - 1)
                    description.AppendLine(instruction);
                else
                    description.Append(instruction);
            }
            return description.ToString();
        }    

        static ReadOnlySpan<string> FormatInstructions(this AsmFunction src, AsmFormatConfig fmt)
        {
            var lines = new List<string>();
            for(var i = 0; i< src.InstructionCount; i++)
                lines.Add(src.Instructions[i].FormatInstruction(fmt));
            return lines.ToArray();
        }    

        static string Format(this AsmMemInfo src)
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

        static string Format(this AsmInstructionSpec src, AsmFormatConfig fmt)
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
        };

        /// <summary>
        /// Formats a single operand
        /// </summary>
        /// <param name="src">The source operand</param>
        static string Format(this AsmOperandInfo src)
        {
            var fmt = src.ImmInfo.Map(i => $"{i.Value.FormatHex(false,true,false,false)}:{i.Label}", () => string.Empty);
            fmt += src.Register.Map(r => r.RegisterName, () => string.Empty);
            fmt += src.Memory.Map(r => r.Format(), () => string.Empty);
            fmt += src.Branch.Map(b => b.Format(), () => string.Empty);
            if(string.IsNullOrWhiteSpace(fmt))
                fmt = src.Kind;
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

            public AsmOutput(TextWriter writer, ulong BaseAddress)
            {
                this.Writer = writer;
                this.BaseAddress = BaseAddress;
            }
            
            public override void Write(string text, FormatterOutputTextKind kind)
            {
                switch(kind)
                {
                    case FormatterOutputTextKind.LabelAddress:
                        var x = text.EndsWith(AsciLower.h) ? text.Substring(0, text.Length - 1)  : text;
                        if(ulong.TryParse(x, System.Globalization.NumberStyles.HexNumber,null, out var address))
                        {
                            Writer.Write((address - BaseAddress).FormatSmallHex(true));
                        }
                        else
                            Writer.Write($"{text}{AsciSym.Question}");
                    break;
                    default:
                        Writer.Write(text);    
                    break;
                }
            }                
        }

    }
}