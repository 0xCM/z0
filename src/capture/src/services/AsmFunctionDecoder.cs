//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static AsmCore;

    using Iced = Iced.Intel;

    readonly struct AsmFunctionDecoder : IAsmFunctionDecoder
    {
        readonly AsmFormatSpec AsmFormat;
        
        public static AsmFunctionDecoder Default
        {
            [MethodImpl(Inline)]         
            get => new AsmFunctionDecoder(AsmFormatSpec.Default);
        }

        [MethodImpl(Inline)]
        internal AsmFunctionDecoder(in AsmFormatSpec format)
        {
            AsmFormat = format;
        }

        public Option<AsmFunction> Decode(CapturedCode src)
            => from i in Decode(src.Encoded)
                let block = AsmInstructionBlock.Define(src.HostedBits, i, src.TermCode)
                select Services.FunctionBuilder.BuildFunction(src.OpUri, src.Method.Signature().Format(), block);

        public Option<AsmFunction> Decode(ParsedExtraction src)
            =>  from i in Decode(src.Encoded) select AsmFunction.define(src,i);

        public Option<AsmInstructionList> Decode(LocatedCode src)        
            => Decode(src.Encoded, src.Address).TryMap(x => AsmInstructionList.Create(x, src));

        public Option<AsmInstructions> Decode(IdentifiedCode src)        
            => Decode(src.Encoded, MemoryAddress.Empty);

        public Option<AsmFunction> Decode(ParsedExtraction src, Action<Asm.Instruction> f)
            => Decode(src.Encoded,f).TryMap(x => AsmFunction.define(src,x));

        public Option<AsmInstructionList> Decode(LocatedCode src, Action<Asm.Instruction> f)        
        {
            try
            {
                var decoded = new Iced.InstructionList();
                var reader = new Iced.ByteArrayCodeReader(src.Encoded);
                var formatter = AsmCaptureFormatter.Create(AsmFormat);
                var decoder = Iced.Decoder.Create(IntPtr.Size * 8, reader);
                var @base = src.Address;
                decoder.IP = @base;
                var stop = false;
                var dst = new List<Asm.Instruction>(decoded.Count);

                while (reader.CanReadByte && !stop) 
                {
                    ref var iced = ref decoded.AllocUninitializedElement();
                    decoder.Decode(out iced); 
                    var format = formatter.FormatInstruction(iced, @base);
                    var z = IceExtractors.Inxs(iced,format);
                    dst.Add(z);
                    f(z);
                }
                return AsmInstructionList.Create(dst.ToArray(), src);

            }
            catch(Exception e)
            {
                term.error(e);     
                return Option.none<AsmInstructionList>();           
            }
        }

        Option<AsmInstructions> Decode(BinaryCode code, MemoryAddress @base)        
        {
            try
            {   
                if(code.IsEmpty)
                {
                    term.warn("Supplied source was empty");
                    return Option.none<AsmInstructions>();
                }

                var decoded = new Iced.InstructionList();
                var reader = new Iced.ByteArrayCodeReader(code.Encoded);
                var decoder = Iced.Decoder.Create(IntPtr.Size * 8, reader);
                decoder.IP = @base;
                while (reader.CanReadByte) 
                {
                    ref var instruction = ref decoded.AllocUninitializedElement();
                    decoder.Decode(out instruction); 
                }

                var formatter = AsmCaptureFormatter.Create(AsmFormat);
                var instructions = new Asm.Instruction[decoded.Count];
                var formatted = formatter.FormatInstructions(decoded, @base);
                for(var i=0; i<instructions.Length; i++)
                    instructions[i] = IceExtractors.Inxs(decoded[i], formatted[i]);
                return AsmInstructions.Create(instructions, code);
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<AsmInstructions>();
            }
        }
    }
}