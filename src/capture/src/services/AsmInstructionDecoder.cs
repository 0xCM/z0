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

    readonly struct AsmInstructionDecoder : IAsmInstructionDecoder
    {
        readonly AsmFormatSpec AsmFormat;

        [MethodImpl(Inline)]
        internal AsmInstructionDecoder(in AsmFormatSpec format)
        {
            this.AsmFormat = format;
        }

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        [MethodImpl(Inline)]
        public Option<AsmInstructionList> DecodeInstructions(in OperationBits src)
            => DecodeInstructions(src.Encoded);

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        public Option<AsmInstructionList> DecodeInstructions(in LocatedCode src)        
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
                    instructions[i] = decoded[i].ToInstruction(formatted[i]);
                return AsmInstructionList.Create(instructions,src);
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<AsmInstructionList>();
            }
        }

        public void DecodeInstructions(in LocatedCode src, Func<Asm.Instruction,bool> f)        
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
                    stop = !f(instruction.ToInstruction(format));
                }

            }
            catch(Exception e)
            {
                term.error(e);                
            }
        }
    }
}