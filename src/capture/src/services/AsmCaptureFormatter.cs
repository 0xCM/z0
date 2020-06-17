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

    using static Konst;
    
    using Iced = Iced.Intel;

    interface IAsmCaptureFormatter : IService
    {
        string FormatInstruction(in Iced.Instruction src, ulong @base);

        ReadOnlySpan<string> FormatInstructions(Iced.InstructionList src, ulong @base);
    }

    readonly struct AsmCaptureFormatter : IAsmCaptureFormatter
    {
        readonly AsmFormatSpec Config;

        readonly Iced.MasmFormatter MasmFormatter;

        [MethodImpl(Inline)]
        public static IAsmCaptureFormatter Create(in AsmFormatSpec config)
            => new AsmCaptureFormatter(config);

        static Iced.MasmFormatterOptions DefaultOptions => new Iced.MasmFormatterOptions
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
            };

        [MethodImpl(Inline)]
        AsmCaptureFormatter(in AsmFormatSpec config)
        {
            Config = config;
            MasmFormatter = new Iced.MasmFormatter(DefaultOptions);                           
        }

        public string FormatInstruction(in Iced.Instruction src, ulong @base)
        {
            var sb = text.build();
            var writer = new StringWriter(sb);
            var output = new AsmOutput(writer, @base);
            MasmFormatter.Format(in src, output);
            return sb.ToString();
        }

        public ReadOnlySpan<string> FormatInstructions(Iced.InstructionList src, ulong @base)
        {                        
            if(src.Count == 0)
                return ReadOnlySpan<string>.Empty;

            var dst = new string[src.Count];
            var sb = text.build();
            var writer = new StringWriter(sb);
            var output = new AsmOutput(writer, @base);
            for(var i = 0; i < src.Count; i++)
            {
                ref readonly var instruction = ref src[i];
                MasmFormatter.Format(in instruction, output);                    
                dst[i] = sb.ToString();
                sb.Clear();
            }
            return dst;
        }

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
                        Writer.Write(AsmFormat.label(text, BaseAddress));
                    break;
                    default:
                        Writer.Write(text);    
                    break;
                }
            }                
        }
    }
}