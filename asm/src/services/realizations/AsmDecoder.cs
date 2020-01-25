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
    using System.Collections.Generic;

    using Z0.AsmSpecs;
    
    using static AsmServiceMessages;
    using static zfunc;
    
    using Iced = Iced.Intel;

    public class AsmDecoder : IAsmDecoder
    {
        internal static IAsmDecoder Create(ClrMetadataIndex index = null, int? bufferlen = null)
            => new AsmDecoder(index,bufferlen);

        byte[] _Buffer;

        Option<ClrMetadataIndex> ClrMetadata;

        AsmDecoder(ClrMetadataIndex index, int? bufferlen)
        {
            this.ClrMetadata = index;
            this._Buffer = new byte[bufferlen ?? 4*1024];
        }

        AsmFormatConfig FormatConfig {get;}
            = AsmFormatConfig.Default;
        
        IAsmSpecBuilder SpecBuilder
            => AsmServices.SpecBuilder();

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        public AsmInstructionList DecodeList(AsmCode src)
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
            var formatted = AsmServices.BaseFormatter().CaptureBaseFormat(decoded,src.Origin.Start);
            for(var i=0; i<dst.Length; i++)
                dst[i] =  SpecBuilder.Instruction(decoded[i],formatted[i]);
            return AsmInstructionList.Create(dst);
        }

        /// <summary>
        /// Decodes a function from a native capture
        /// </summary>
        /// <param name="src">The cource capture</param>
        public AsmFunction DecodeFunction(MemberCapture src)
        {
            var list = DecodeList(src.Code);
            var block = AsmSpecs.AsmInstructionBlock.Define(src.Code, list, src.CaptureInfo.TermCode);
            var cil = ClrMetadata.MapValueOrDefault(idx => idx.FindCilFunction(src.Method).ValueOrDefault());
            return BuildFunction(block).WithCil(cil);            
        }

        /// <summary>
        /// Decodes a function from a method
        /// </summary>
        /// <param name="src">The cource capture</param>
        public AsmFunction DecodeFunction(Moniker id, MethodInfo src)
            => DecodeFunction(NativeReader.read(id, src, TakeBuffer()));

        /// <summary>
        /// Decodes an assembly function from a dynamic delegate
        /// </summary>
        /// <param name="id">The identity to confer</param>
        /// <param name="src">The source delegate</param>
        public AsmFunction DecodeFunction(DynamicDelegate src)
            => DecodeFunction(NativeReader.read(src.Id, src, TakeBuffer()));

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

            return AsmFunction.Define(src.Origin, src.NativeCode, src.TermCode, src.Decoded);
        }

        byte[] TakeBuffer()
        {
            _Buffer.Clear();
            return _Buffer;
        }
    }
}