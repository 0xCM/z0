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
 
    using Z0.AsmSpecs;
    
    using static AsmServiceMessages;
    using static zfunc;
    
    using Iced = Iced.Intel;

    class AsmDecoder : IAsmDecoder
    {
        public IAsmContext Context {get;}

        readonly byte[] Buffer;

        readonly bool EmitCil;

        public static IAsmDecoder Create(IAsmContext context, bool emitcil = true)
            => new AsmDecoder(context, CaptureServices.DefaultBufferLen, emitcil);

        AsmDecoder(IAsmContext context, int bufferlen, bool cil)
        {
            this.Context = context;
            this.EmitCil = cil;
            this.Buffer = new byte[bufferlen];
        }
    
        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        public AsmInstructionList Decode(AsmCode src)
        {
            var decoded = new Iced.InstructionList();
            var reader = new Iced.ByteArrayCodeReader(src.Encoded);
			var decoder =Iced.Decoder.Create(IntPtr.Size * 8, reader);
            decoder.IP = src.Origin.Start;
			while (reader.CanReadByte) 
			{
				ref var instruction = ref decoded.AllocUninitializedElement();
				decoder.Decode(out instruction); 
			}

            var dst = new AsmSpecs.Instruction[decoded.Count];
            var formatted = Context.InstructionFormatter().FormatInstructions(decoded,src.Origin.Start);
            for(var i=0; i<dst.Length; i++)
                dst[i] =  decoded[i].ToSpec(formatted[i]);
            return AsmInstructionList.Create(dst);
        }

        /// <summary>
        /// Decodes a function from a native capture
        /// </summary>
        /// <param name="src">The cource capture</param>
        public AsmFunction Decode(CapturedMember src)
        {
            var list = Decode(src.Code);
            var block = AsmSpecs.AsmInstructionBlock.Define(src.Code, list, src.Outcome);
            var f = BuildFunction(block);

            if(EmitCil)
            {
                var cil = Context.ClrIndex.FindCil(src.Method).ValueOrDefault();
                return f.WithCil(cil);            
            }
            else
                return f;
        }

        AsmFunction BuildFunction(AsmInstructionBlock src)
        {
            var dst = new AsmInstructionInfo[src.InstructionCount];
            var offset = (ushort)0;

            for(var i=0; i<dst.Length; i++)
            {
                var instruction = src[i];
                
                if(src.NativeCode.Length < offset + instruction.ByteLength)
                    throw error(InstructionSizeMismatch(instruction.IP, offset, src.NativeCode.Length, instruction.ByteLength));                
            
                dst[i] = instruction.SummarizeInstruction(src.NativeCode.Encoded, instruction.FormattedInstruction, offset, src.Origin.Start);
                offset += (ushort)instruction.ByteLength;
            }

            var blocklen = src.Decoded.Select(i => i.ByteLength).Sum();
            if(blocklen != src.NativeCode.Length)
                throw error(InstructionBlockSizeMismatch(src.Origin, src.NativeCode.Length, blocklen));

            return AsmFunction.Define(src.Origin, src.NativeCode, src.CaptureInfo, src.Decoded);
        }
    }
}