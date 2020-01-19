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
    
    public static class AsmFormatX
    {
        public static string Format(this CilFunction src)
        {
            var rendered = text();

            var margin = new string(AsciSym.Space,4);
            rendered.AppendLine($"Id := {src.MethodId}, Name := {src.FullName}".Comment());
            src.Sig.TryMap(s => rendered.AppendLine(s.Format().Comment()));
            rendered.AppendLine(src.ImplSpec.ToString().Comment());            
            rendered.AppendLine(src.Sig.MapValueOrElse(s => s.Format(), () => string.Empty));
            rendered.AppendLine(AsciSym.LBrace);                    
            
            foreach(var i in src.Instructions)
                rendered.AppendLine(margin + i.ToString());
            rendered.AppendLine(AsciSym.RBrace);                        
            
            return rendered.ToString();
        }

        public static string FormatCil(this MethodDisassembly src)
            => src.CilFunction.MapValueOrElse(f => f.Format(), () => string.Empty);

        public static ReadOnlySpan<string> Format(this MethodAsmBody src, AsmFormatConfig config)
            => InstructionBlock.Define(
                Moniker.Provider.Define(src.Method),
                src.Method.Signature().Format(), 
                src.NativeBlock.Data, 
                src.Instructions).Format(config ?? AsmFormatConfig.Default);

        public static string Format(this MethodAsmBody src)
        {
            if(src.Instructions.Length == 0)
                return string.Empty;

            Span<byte> nativeData = src.NativeBlock.Data;

            var baseAddress = src.Instructions[0].IP;

            var formatter = new MasmFormatter(FormatOptions);
            var sb = text();

            var writer = new StringWriter(sb);
            var output = new AsmOutput(writer, baseAddress);
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

        static string comment(string src)
            => $"{AsciSym.Semicolon}{AsciSym.Space}{src}";

        public static string FormatLines(this InstructionBlock src, AsmFormatConfig config = null)
            => src.Format(config ?? AsmFormatConfig.Default).FormatLines();

        public static ReadOnlySpan<string> Format(this InstructionBlock src, AsmFormatConfig config = null)
        {
            const string RelAddresSpec = "x4";

            config = config ?? AsmFormatConfig.Default;

            if(src.InstructionCount == 0)
                return ReadOnlySpan<string>.Empty;
            
            var linecount = src.InstructionCount;
            if(config.EmitHeader)
            {
                linecount++;
                if(config.TimestampHeader)
                    linecount++;
            }

            var line = 0;
            Span<string> dst = new string[linecount];
            if(config.EmitHeader)                
                dst[line++] = comment(src.Label);
            if(config.TimestampHeader)
                dst[line++] = comment(now().ToLexicalString());


            var formatter = new MasmFormatter(FormatOptions);
            var baseAddress = src.BaseAddress;

            var sb = text();
            var writer = new StringWriter(sb);
            var output = new AsmOutput(writer, baseAddress);
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