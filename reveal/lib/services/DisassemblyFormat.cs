//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;
	using Iced.Intel;
    using System.IO;

    using static zfunc;
    
    public static class DisassemblyFormat
    {
        public static string Format(this InstructionBlock src, AsmFormatConfig config = null)
            => src.FormatAsm(config ?? AsmFormatConfig.Default).FormatLines();


        public static string FormatCil(this MethodDisassembly src)
        {
            var format = text();
            format.AppendLine(src.MethodSig.Format());
            format.AppendLine(AsciSym.LBrace.ToString());
            format.AppendLine(src.CilBody.ToString());
            format.Append(AsciSym.RBrace.ToString());
            return format.ToString();
        }

        public static string Format(this MethodAsmBody src)
        {
            if(src.Instructions.Length == 0)
                return string.Empty;

            Span<byte> nativeData = src.NativeBlock.Data;

            var baseAddress = src.Instructions[0].IP;

            var formatter = new MasmFormatter(FormatOptions);
            var sb = text();

            var writer = new StringWriter(sb);
            var output = new AsmFormatterOutput(writer, baseAddress);
            for(var j = 0; j< src.Instructions.Length; j++)
            {
                ref var i = ref src.Instructions[j];
                
                var startAddress = i.IP;
                var relAddress = (int)(startAddress - baseAddress);
                var relAddressFmt = relAddress.ToString("x4");            
                sb.Append($"{relAddressFmt}h  ");

                formatter.Format(ref i, output);

                var padding = "   ";
                var encoding = i.Encoding == EncodingKind.Legacy ? string.Empty : $" ({i.Encoding} encoded)";               
                var encoded = embrace(nativeData.Slice(relAddress, i.ByteLength).FormatHex(false, ','));
                sb.Append($"{padding}; opcode := {i.Code}{encoding} | encoded := {encoded} ({i.ByteLength} bytes)");
                
                if(j != src.Instructions.Length - 1)
                    sb.AppendLine();
            }
                
            return sb.ToString();
        }

        static string comment(string src, string ts)
            => $"{AsciSym.Semicolon}{AsciSym.Space}{src}{ts}";

        public static ReadOnlySpan<string> FormatAsm(this InstructionBlock src, AsmFormatConfig config)
        {
            const string RelAddresSpec = "x4";

            if(src.InstructionCount == 0)
                return ReadOnlySpan<string>.Empty;
            
            var linecount = config.EmitHeader ? src.InstructionCount + 1 : src.InstructionCount;
            var line = 0;
            Span<string> dst = new string[linecount];
            if(config.EmitHeader)                
                dst[line++] = comment(src.Identity, config.TimestampHeader ? $" {now().ToLexicalString()}" : string.Empty);

            var formatter = new MasmFormatter(FormatOptions);
            var baseAddress = src.BaseAddress;

            var sb = text();
            var writer = new StringWriter(sb);
            var output = new AsmFormatterOutput(writer, baseAddress);
            for(var current = 0; current < src.InstructionCount; line++, current++)
            {
                ref var instruction = ref src[current];

                formatter.Format(ref instruction, output);
                var relAddress = (int)(instruction.IP - baseAddress);                
                
                dst[line] = config.ShowLineAddresses
                    ?  concat(relAddress.ToString(RelAddresSpec), Hex.PostSpec, AsciSym.Space, sb.ToString())
                    :   sb.ToString();

                if(config.ShowRawBytes)
                    dst[line] = dst[line].PadRight(50) 
                          + concat(AsciSym.Semicolon, AsciSym.Space) 
                          + src.Encoded.Slice(relAddress, instruction.ByteLength)
                                .FormatHexBytes(sep:AsciSym.Space, zpad:true, specifier:false, uppercase:false);

                sb.Clear();
            }

            return dst;
        }

        public static ReadOnlySpan<string> FormatAsm(this MethodAsmBody src, AsmFormatConfig config = null)
            => InstructionBlock.Define(src.Method.Signature().Format(), src.NativeBlock.Data, src.Instructions).FormatAsm(config ?? AsmFormatConfig.Default);

        class AsmFormatterOutput : FormatterOutput
        {
            TextWriter Writer {get;}
            
            ulong BaseAddress {get;}

            public AsmFormatterOutput(TextWriter writer, ulong BaseAddress)
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
                            var ra = (address - BaseAddress).ToString("x4");
                            var label = $"{ra}h";
                            Writer.Write(label);
                        }
                        else
                        {
                            Writer.Write($"{text}{AsciSym.Question}");
                        }
                    break;
                    default:
                        Writer.Write(text);    
                    break;
                }
            }                
        }

        static MasmFormatterOptions FormatOptions => new MasmFormatterOptions
        {
            DecimalDigitGroupSize = 4,
            BranchLeadingZeroes = false,
            HexDigitGroupSize = 4,
            UpperCaseRegisters = false, 
            LeadingZeroes = false,
            DisplInBrackets = true,
            
        };

    }
}