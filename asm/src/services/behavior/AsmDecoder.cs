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

    public static class AsmDecoder
    {
        /// <summary>
        /// Constructs a method disassembly
        /// </summary>
        /// <param name="id">The disassembly id</param>
        /// <param name="m">The source method</param>
        /// <param name="index">The clr metadata index to use, if any</param>
        public static Option<MethodDisassembly> method(Moniker id, MethodInfo m, ClrMetadataIndex index)
        {
            try
            {                
                Span<byte> buffer = new byte[NativeReader.DefaultBufferLen];
                var asmBody =  AsmDecoder.body(m,buffer);
                var cilfunc = index != null ? index.FindCilFunction(m).ValueOrDefault() : default;                        
                return MethodDisassembly.Define(id, asmBody, cilfunc);                
            }
            catch(NoCodeException)
            {
                warn($"{m.DisplayName()}: No code was found");
                return none<MethodDisassembly>();
            }
            catch(Exception e)
            {
                error(e.ToString());
                return none<MethodDisassembly>();
            }
        }

        /// <summary>
        /// Decodes an instruction block
        /// </summary>
        /// <param name="code">The encoded assembly</param>
        /// <param name="location">The memory location from which the code was extracted</param>
        public static InstructionBlock block(AsmCode code, MemoryRange location)
            => block(code.Id, code.Label, location, code.Encoded);

        /// <summary>
        /// Decones an instruction block
        /// </summary>
        /// <param name="id">The identity to confer upon the block</param>
        /// <param name="label">Descriptive text</param>
        /// <param name="location">The memory location from which the endoded data was extracted</param>
        /// <param name="data">The encoded data</param>
        public static InstructionBlock block(Moniker id, string label, MemoryRange location, byte[] data)
		{
            var dst = new InstructionList();
            var reader = new ByteArrayCodeReader(data);
			var decoder = Decoder.Create(IntPtr.Size * 8, reader);
			decoder.IP = 0;
			while (reader.CanReadByte) 
			{
				ref var instruction = ref dst.AllocUninitializedElement();
				decoder.Decode(out instruction);                
			}
            return InstructionBlock.Define(id, label, location, data, dst.ToArray());
		}

        /// <summary>
        /// Decodes an instruction block
        /// </summary>
        /// <param name="src">The native source data</param>
        public static InstructionBlock block(INativeMemberData src)
		{
            var dst = new InstructionList();
            var reader = new ByteArrayCodeReader(src.Code.Encoded);
			var decoder = Decoder.Create(IntPtr.Size * 8, reader);
			decoder.IP = 0;
			while (reader.CanReadByte) 
			{
				ref var instruction = ref dst.AllocUninitializedElement();
				decoder.Decode(out instruction);                
			}
            return InstructionBlock.Define(src.Id, src.Label, src.Location, src.Code.Encoded, dst.ToArray());
		}

        public static MethodAsmBody body(MethodInfo method, Span<byte> buffer)
        {
            var data = NativeReader.read(method, buffer);
            if(data.Length == 0)
                throw new NoCodeException(method.ToString());

            var block = NativeCodeBlock.Define(data);
            return MethodAsmBody.Define(method, block, list(block));
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
        public static IEnumerable<InstructionBlock> blocks<T>(IEnumerable<T> src)
            where T : INativeMemberData
                => from member in src select block(member);
                
        /// <summary>
        /// Decodes an assembly function from native member data
        /// </summary>
        /// <param name="src">The source data</param>
        public static AsmFuncInfo function(INativeMemberData src)
            => AsmFunction.define(block(src));

        /// <summary>
        /// Decodes an assembly function from a dynamic delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        public static AsmFuncInfo function(DynamicDelegate f, Moniker id, byte[] buffer)
            => function(NativeReader.read(f, buffer));
    }
}