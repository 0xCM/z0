//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
     
    using static Core;

    using Iced = Iced.Intel;

    readonly struct AsmInstructionDecoder : IAsmInstructionDecoder
    {
        public IContext Context {get;}

        readonly AsmFormatConfig AsmFormat;

        [MethodImpl(Inline)]
        public static AsmInstructionDecoder Create(IContext context, AsmFormatConfig format)
            => new AsmInstructionDecoder(context, format);

        [MethodImpl(Inline)]
        AsmInstructionDecoder(IContext context, AsmFormatConfig format)
        {
            this.Context = context;
            this.AsmFormat = format;
        }

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        [MethodImpl(Inline)]
        public Option<AsmInstructionList> DecodeInstructions(AsmCode src)
            => DecodeInstructions(src.Data);

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        [MethodImpl(Inline)]
        public Option<AsmInstructionList> DecodeInstructions(MemoryExtract src)        
        {
            try
            {
                var decoded = new Iced.InstructionList();
                var reader = new Iced.ByteArrayCodeReader(src.Bytes);
                var decoder =Iced.Decoder.Create(IntPtr.Size * 8, reader);
                decoder.IP = src.AddressRange.Start;
                while (reader.CanReadByte) 
                {
                    ref var instruction = ref decoded.AllocUninitializedElement();
                    decoder.Decode(out instruction); 
                }

                var instructions = new Asm.Instruction[decoded.Count];
                var formatted = AsmFormatter.Internal(AsmFormat).FormatInstructions(decoded, src.Address);
                for(var i=0; i<instructions.Length; i++)
                    instructions[i] =  decoded[i].ToInstruction(formatted[i]);
                return AsmInstructionList.Create(instructions,src);
            }
            catch(Exception e)
            {
                term.error(e);
                return none<AsmInstructionList>();
            }
        }
    }
}