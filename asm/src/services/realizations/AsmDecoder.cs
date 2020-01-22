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
 	using Iced.Intel;

    using static zfunc;

    public class AsmDecoder : IAsmDecoder
    {
        internal static IAsmDecoder Create(ClrMetadataIndex index = null, int? bufferlen = null)
            => new AsmDecoder(index,bufferlen);

        byte[] _Buffer;

        Option<ClrMetadataIndex> ClrMetadata;

        AsmDecoder(ClrMetadataIndex index,int? bufferlen)
        {
            this.ClrMetadata = index;
            this._Buffer = new byte[bufferlen ?? 4*1024];
        }

        public AsmFunction DecodeFunction(Moniker id, MethodInfo src)
            => function(NativeReader.read(id, src, TakeBuffer()), ClrMetadata.ValueOrDefault());

        public AsmFunction DecodeFunction(NativeMemberCapture src)
            => DecodeFunction(src.Id, src.Method);

        public AsmFunction DecodeFunction(Moniker id, DynamicDelegate src)
            => function(id, src, TakeBuffer(), ClrMetadata.ValueOrDefault());

        byte[] TakeBuffer()
        {
            _Buffer.Clear();
            return _Buffer;
        }

        /// <summary>
        /// Decodes an assembly function from native member data
        /// </summary>
        /// <param name="src">The source data</param>
        public static AsmFunction function(NativeMemberCapture src, ClrMetadataIndex index)
		{
            var block = instructions(src.Code, src.CaptureInfo.TermCode, src.Origin);
            var cil = index?.FindCilFunction(src.Method).ValueOrDefault();            
            return AsmServices.FunctionBuilder().BuildFunction(block).WithCil(cil);
		}

        /// <summary>
        /// Decodes a stream of instruction blocks
        /// </summary>
        /// <param name="src">The native source data</param>
        /// <typeparam name="T">The native source type</typeparam>
        public static IEnumerable<AsmFunction> functions(IEnumerable<NativeMemberCapture> src)
            => from member in src select function(member);

        /// <summary>
        /// Decodes an instruction block
        /// </summary>
        /// <param name="src">The native source data</param>
        public static AsmFunction function(NativeMemberCapture src)
            => function(src,null);
            
        /// <summary>
        /// Decodes an assembly function from a dynamic delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        public static AsmFunction function(Moniker id, DynamicDelegate src, byte[] dst, ClrMetadataIndex index = null)
            => function(NativeReader.read(id, src, dst), index);

        /// <summary>
        /// Decodes an asm function
        /// </summary>
        /// <param name="id">The disassembly id</param>
        /// <param name="src">The source method</param>
        /// <param name="dst">The clr metadata index to use, if any</param>
        static AsmFunction function(Moniker id, MethodInfo src, byte[] dst)
            => function(NativeReader.read(id, src, dst));

        /// <summary>
        /// Decodes an instruction block
        /// </summary>
        /// <param name="id">The identity to confer upon the block</param>
        /// <param name="label">Descriptive text</param>
        /// <param name="origin">The memory location from which the endoded data was extracted</param>
        /// <param name="data">The encoded data</param>
        static AsmFunction function(Moniker id, string label, MemoryRange origin, byte[] data)
		{
            var dst = new InstructionList();
            var reader = new ByteArrayCodeReader(data);
			var decoder = Decoder.Create(IntPtr.Size * 8, reader);
            decoder.IP = origin.Start;
			while (reader.CanReadByte) 
			{
				ref var instruction = ref dst.AllocUninitializedElement();
				decoder.Decode(out instruction);                
			}
            var block = InstructionBlock.Define(AsmCode.Define(id, origin, label, data), CaptureTermCode.EOB, origin, dst);
            return AsmServices.FunctionBuilder().BuildFunction(block);
		}

        /// <summary>
        /// Decodes an instruction sequence
        /// </summary>
        /// <param name="src">The native source block</param>
        static IEnumerable<Instruction> instructions(AsmCode src)
		{
            var dst = new InstructionList();
            var reader = new ByteArrayCodeReader(src.Encoded);
			var decoder = Decoder.Create(IntPtr.Size * 8, reader);
			decoder.IP = src.Origin.Start;			
			while (reader.CanReadByte) 
			{
				ref var instruction = ref dst.AllocUninitializedElement();
				decoder.Decode(out instruction);                
			}
            return dst;
		}

        /// <summary>
        /// Decodes an instruction block
        /// </summary>
        /// <param name="src">The encoded source</param>
        /// <param name="origin">The memory range from which the code was extracted</param>
        static InstructionBlock instructions(AsmCode src, CaptureTermCode tc, MemoryRange origin)
		{
            var dst = new InstructionList();
            var reader = new ByteArrayCodeReader(src.Encoded);
			var decoder = Decoder.Create(IntPtr.Size * 8, reader);
            decoder.IP = origin.Start;
			while (reader.CanReadByte) 
			{
				ref var instruction = ref dst.AllocUninitializedElement();
				decoder.Decode(out instruction);                
			}
            return InstructionBlock.Define(src, tc, origin, dst);
        }
    }
}