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

    using Iced = Iced.Intel;

    readonly struct AsmRoutineDecoder : IAsmRoutineDecoder
    {
        readonly AsmFormatSpec AsmFormat;
        
        public static AsmRoutineDecoder Default
        {
            [MethodImpl(Inline)]         
            get => new AsmRoutineDecoder(AsmFormatSpec.Default);
        }

        [MethodImpl(Inline)]
        public AsmRoutineDecoder(in AsmFormatSpec format)
            => AsmFormat = format;

        public Option<AsmRoutine> Decode(CapturedCode src)
            => from i in Decode(src.Encoded)
                let block = asm.block(src.HostedBits, i, src.TermCode)
                select asm.routine(src.OpUri, src.Method.Signature().Format(), block);

        public Option<AsmRoutine> Decode(ParsedExtraction src)
            =>  from i in Decode(src.Encoded) select asm.routine(src,i);

        public Option<AsmFxList> Decode(LocatedCode src)        
            => Decode(src.Encoded, src.Address).TryMap(x => asm.list(x, src));

        public Option<AsmInstructions> Decode(IdentifiedCode src)        
            => Decode(src.Encoded, MemoryAddress.Empty);

        public Option<AsmRoutine> Decode(ParsedExtraction src, Action<Asm.Instruction> f)
            => Decode(src.Encoded,f).TryMap(x => asm.routine(src,x));

        public Option<AsmFxList> Decode(LocatedCode src, Action<Asm.Instruction> f)        
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
                return asm.list(dst.ToArray(), src);

            }
            catch(Exception e)
            {
                term.error(e);     
                return Option.none<AsmFxList>();           
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