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

        public AsmFunction DecodeFunction(AsmCode src, MemoryRange location)
            => function(src.Id, src.Label, location, src.Encoded);

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
            var dst = new InstructionList();
            var reader = new ByteArrayCodeReader(src.Code.Encoded);
			var decoder = Decoder.Create(IntPtr.Size * 8, reader);
            var cil = index?.FindCilFunction(src.Method).ValueOrDefault();
            decoder.IP = src.Location.Start;
			while (reader.CanReadByte) 
			{
				ref var instruction = ref dst.AllocUninitializedElement();
				decoder.Decode(out instruction);                
			}
            var block = InstructionBlock.Define(src.Id, src.Label, src.Location, src.Code.Encoded, dst.ToArray());
            return AsmServices.FunctionBuilder().BuildFunction(block,cil);
		}

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
        public static AsmFunction function(Moniker id, DynamicDelegate src, byte[] buffer, ClrMetadataIndex index = null)
            => function(NativeReader.read(id, src, buffer), index);

        /// <summary>
        /// Constructs a method disassembly
        /// </summary>
        /// <param name="id">The disassembly id</param>
        /// <param name="src">The source method</param>
        /// <param name="index">The clr metadata index to use, if any</param>
        public static AsmFunction function(Moniker id, MethodInfo src, ClrMetadataIndex index)
            => function(NativeReader.read(id, src, new byte[NativeReader.DefaultBufferLen]), index);

        /// <summary>
        /// Decones an instruction block
        /// </summary>
        /// <param name="id">The identity to confer upon the block</param>
        /// <param name="label">Descriptive text</param>
        /// <param name="location">The memory location from which the endoded data was extracted</param>
        /// <param name="data">The encoded data</param>
        public static AsmFunction function(Moniker id, string label, MemoryRange location, byte[] data)
		{
            var dst = new InstructionList();
            var reader = new ByteArrayCodeReader(data);
			var decoder = Decoder.Create(IntPtr.Size * 8, reader);
            decoder.IP = location.Start;
			while (reader.CanReadByte) 
			{
				ref var instruction = ref dst.AllocUninitializedElement();
				decoder.Decode(out instruction);                
			}
            var block = InstructionBlock.Define(id, label, location, data, dst.ToArray());
            return AsmServices.FunctionBuilder().BuildFunction(block);
		}

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The native source block</param>
        public static InstructionList list(NativeCodeBlock src)
		{
            var dst = new InstructionList();
            var reader = new ByteArrayCodeReader(src.Data);
			var decoder = Decoder.Create(IntPtr.Size * 8, reader);
			decoder.IP = src.Location.Start;			
			while (reader.CanReadByte) 
			{
				ref var instruction = ref dst.AllocUninitializedElement();
				decoder.Decode(out instruction);                
			}
            return dst;
		}

        /// <summary>
        /// Decodes a stream of instruction blocks
        /// </summary>
        /// <param name="src">The native source data</param>
        /// <typeparam name="T">The native source type</typeparam>
        public static IEnumerable<AsmFunction> functions(IEnumerable<NativeMemberCapture> src)
            => from member in src select function(member);



    }
}