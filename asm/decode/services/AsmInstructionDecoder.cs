//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
     
    using static Seed;

    using Iced = Iced.Intel;

    readonly struct AsmInstructionDecoder : IAsmInstructionDecoder
    {
        readonly AsmFormatConfig AsmFormat;

        [MethodImpl(Inline)]
        public static AsmInstructionDecoder Create(IContext context, in AsmFormatConfig format)
            => new AsmInstructionDecoder(format);

        [MethodImpl(Inline)]
        AsmInstructionDecoder(in AsmFormatConfig format)
        {
            this.AsmFormat = format;
        }

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        [MethodImpl(Inline)]
        public Option<AsmInstructionList> DecodeInstructions(in AsmCode src)
            => DecodeInstructions(src.Data);

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        public Option<AsmInstructionList> DecodeInstructions(in MemoryExtract src)        
        {
            try
            {
                var decoded = new Iced.InstructionList();
                var reader = new Iced.ByteArrayCodeReader(src.Bytes);
                var decoder = Iced.Decoder.Create(IntPtr.Size * 8, reader);
                decoder.IP = src.AddressRange.Start;
                while (reader.CanReadByte) 
                {
                    ref var instruction = ref decoded.AllocUninitializedElement();
                    decoder.Decode(out instruction); 
                }

                var instructions = new Asm.Instruction[decoded.Count];
                var formatted = AsmFormatter.Internal(AsmFormat).FormatInstructions(decoded, src.Address);
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

        public void DecodeInstructions(in MemoryExtract src, Func<Asm.Instruction,bool> f)        
        {
            try
            {
                var decoded = new Iced.InstructionList();
                var reader = new Iced.ByteArrayCodeReader(src.Bytes);
                var formatter = AsmFormatter.Internal(AsmFormat);
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