//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
 
    using Z0.Asm;
    
    using static Root;

    using Iced = Iced.Intel;

    public static class AsmDecodingOps
    {
        public static Option<AsmInstructionList> DecodeInstructions(this IAsmContext context, EncodedData src)
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
                var formatted = context.InstructionFormatter().FormatInstructions(decoded, src.BaseAddress);
                for(var i=0; i<instructions.Length; i++)
                    instructions[i] =  decoded[i].ToSpec(formatted[i]);
                return AsmInstructionList.Create(instructions,src);
            }
            catch(Exception e)
            {
                term.error(e);
                return none<AsmInstructionList>();
            }
        }

        public static Option<AsmInstructionList> DecodeInstructions(this IAsmContext context, AsmCode src)
            => context.DecodeInstructions(src.Data);            
    }
}