//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
 
    using Z0.Asm;
    
    using Iced = Iced.Intel;

    partial class AsmInternals
    {
        public static AsmInstructionList DecodeInstructions(this IAsmContext context, AsmCode src, ulong @base)
        {
            var decoded = new Iced.InstructionList();
            var reader = new Iced.ByteArrayCodeReader(src.Encoded);
			var decoder =Iced.Decoder.Create(IntPtr.Size * 8, reader);
            decoder.IP = @base;
			while (reader.CanReadByte) 
			{
				ref var instruction = ref decoded.AllocUninitializedElement();
				decoder.Decode(out instruction); 
			}

            var dst = new Asm.Instruction[decoded.Count];
            var formatted = context.InstructionFormatter().FormatInstructions(decoded, @base);
            for(var i=0; i<dst.Length; i++)
                dst[i] =  decoded[i].ToSpec(formatted[i]);
            return AsmInstructionList.Create(dst);
        }

        public static AsmInstructionList DecodeInstructions(this IAsmContext context, AsmCode src)
        {
            var decoded = new Iced.InstructionList();
            var reader = new Iced.ByteArrayCodeReader(src.Encoded);
			var decoder =Iced.Decoder.Create(IntPtr.Size * 8, reader);
            decoder.IP = src.AddressRange.Start;
			while (reader.CanReadByte) 
			{
				ref var instruction = ref decoded.AllocUninitializedElement();
				decoder.Decode(out instruction); 
			}

            var dst = new Asm.Instruction[decoded.Count];
            var formatted = context.InstructionFormatter().FormatInstructions(decoded, src.AddressRange.Start);
            for(var i=0; i<dst.Length; i++)
                dst[i] =  decoded[i].ToSpec(formatted[i]);
            return AsmInstructionList.Create(dst);
        }
    }
}