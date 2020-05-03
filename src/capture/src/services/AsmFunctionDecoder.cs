//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
     
    using static Seed;
    using static Memories;

    using Iced = Iced.Intel;

    readonly struct AsmFunctionDecoder : IAsmFunctionDecoder
    {
        readonly AsmFormatSpec AsmFormat;
        
        [MethodImpl(Inline)]
        internal AsmFunctionDecoder(in AsmFormatSpec format)
        {
            AsmFormat = format;
        }

        static IAsmFunctionBuilder Builder => AsmCore.Services.FunctionBuilder;

        public Option<AsmFunction> Decode(MemberCapture src)
            => DecodeCaptured(src);

        public Option<AsmFunction> Decode(ParsedMember src)
            =>  from i in Decode(OperationBits.Define(src.Uri, src.ParsedContent))
                select AsmFunction.Define(src,i);

        Option<AsmFunction> DecodeCaptured(MemberCapture src)
            => from i in Decode(src.Code)
                let block = AsmInstructionBlock.Define(src.Code, i, src.TermCode)
                select Builder.BuildFunction(src.Uri, src.OpSig.Format(), block);

        public Option<AsmInstructionList> Decode(in OperationBits src)
            => Decode(src.Encoded);

        public Option<AsmInstructionList> Decode(in LocatedCode src)        
        {
            try
            {   
                require(src.IsNonEmpty);
                var decoded = new Iced.InstructionList();
                var reader = new Iced.ByteArrayCodeReader(src.Content);
                var decoder = Iced.Decoder.Create(IntPtr.Size * 8, reader);
                decoder.IP = src.AddressRange.Start;
                while (reader.CanReadByte) 
                {
                    ref var instruction = ref decoded.AllocUninitializedElement();
                    decoder.Decode(out instruction); 
                }

                var formatter = AsmCaptureFormatter.Create(AsmFormat);
                var instructions = new Asm.Instruction[decoded.Count];
                var formatted = formatter.FormatInstructions(decoded, src.Address);
                for(var i=0; i<instructions.Length; i++)
                    instructions[i] = decoded[i].ToZAsm(formatted[i]);
                return AsmInstructionList.Create(instructions,src);
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<AsmInstructionList>();
            }
        }

        public Option<AsmFunction> Decode(ParsedMember src, Action<Asm.Instruction> f)
        {
            try
            {
                var decoded = list<Asm.Instruction>();                
                void OnDecoded(Asm.Instruction src)
                {
                    decoded.Add(src);
                    f(src);
                }
                
                Decode(src.ParsedContent, OnDecoded);
                var list = AsmInstructionList.Create(decoded.ToArray(), src.ParsedContent);
                return AsmFunction.Define(src,list);
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<AsmFunction>();
            }
        }

        public void Decode(in LocatedCode src, Action<Asm.Instruction> f)        
        {
            try
            {
                var decoded = new Iced.InstructionList();
                var reader = new Iced.ByteArrayCodeReader(src.Content);
                var formatter = AsmCaptureFormatter.Create(AsmFormat);
                var decoder = Iced.Decoder.Create(IntPtr.Size * 8, reader);
                decoder.IP = src.AddressRange.Start;
                var stop = false;
                while (reader.CanReadByte && !stop) 
                {
                    ref var instruction = ref decoded.AllocUninitializedElement();
                    decoder.Decode(out instruction); 
                    var format = formatter.FormatInstruction(instruction,src.Address);
                    f(instruction.ToZAsm(format));
                }

            }
            catch(Exception e)
            {
                term.error(e);                
            }
        }
    }
}