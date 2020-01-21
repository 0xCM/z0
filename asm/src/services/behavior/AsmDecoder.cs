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
        public static Option<MethodDisassembly> decode(Moniker id, MethodInfo method, ClrMetadataIndex index)
        {
            try
            {                
                Span<byte> buffer = new byte[NativeReader.DefaultBufferLen];
                var asmBody =  AsmDecoder.decode(method,buffer);
                var cilbody = CilFunctionBody.From(method).Data;
                var cilfunc = index != null ? index.FindCilFunction(method).ValueOrDefault() : default;                        
                return MethodDisassembly.Define(id, asmBody, cilbody,  cilfunc);                
            }
            catch(NoCodeException)
            {
                warn($"{method.DisplayName()}: No code was found");
                return none<MethodDisassembly>();
            }
            catch(Exception e)
            {
                error(e.ToString());
                return none<MethodDisassembly>();
            }
        }

        public static IEnumerable<MethodDisassembly> decode(GenericOpInfo op, ClrMetadataIndex index)
        {
            foreach(var k in op.Kinds)
            {
                var moniker = OpIdentity.Provider.Define(op.Method, k);
                var method = op.Method.MakeGenericMethod(k.ToPrimalType());
                var result = decode(moniker, method, index).ValueOrDefault();
                if(result != null)
                    yield return result;
            }
        }

        /// <summary>
        /// Decodes encoded assembly instructions
        /// </summary>
        /// <param name="data">The encoded instructions</param>
        public static InstructionBlock decode(AsmCode code, MemoryRange location)
            => decode(code.Id, code.Label, location, code.Encoded);

        /// <summary>
        /// Decodes encoded assembly instructions
        /// </summary>
        /// <param name="data">The encoded instructions</param>
        public static InstructionBlock decode(Moniker id, string label, MemoryRange location, byte[] data)
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

        public static MethodAsmBody decode(MethodInfo method, Span<byte> buffer)
        {
            var data = NativeReader.read(method, buffer);
            if(data.Length == 0)
                throw new NoCodeException(method.ToString());

            var block = NativeCodeBlock.Define(data);
            return MethodAsmBody.Define(method, block, decode(block));
        }

        public static InstructionBlock decode(INativeMemberData src)
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

        public static InstructionList decode(NativeCodeBlock src)
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

        public static IEnumerable<InstructionBlock> decode<T>(IEnumerable<T> src)
            where T : INativeMemberData
                => from member in src select decode(member);

        public static AsmCodeSet decode(INativeMemberData src, Moniker moniker, CilFunctionBody cil)
            => AsmCodeSet.Define(moniker, decode(src), cil);

        public static AsmCodeSet decode(DynamicDelegate f, Moniker id, byte[] buffer)
            => decode(NativeReader.read(f, buffer), id, f.CilFunc());
    }
}