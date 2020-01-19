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

    public class NoCodeException : Exception
    {
        public NoCodeException(string method)
            : base($"No code was found for the method ${method}")
        {
            this.MethodName = method;
        }

        public string MethodName {get;}        
    }

    public static class AsmDecoder
    {
        public static Option<MethodDisassembly> decode(MethodInfo method, Moniker id, ClrMetadataIndex index = null)
        {
            try
            {                
                var asmBody =  AsmDecoder.decode(method);
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

        public static IEnumerable<MethodDisassembly> decode(FastGenericInfo op, ClrMetadataIndex index)
        {
            foreach(var moniker in op.Reifications)
            {
                var arg = moniker.PrimalKind.ToPrimalType();
                var method = op.Method.MakeGenericMethod(arg);
                var result = decode(method, moniker, index).ValueOrDefault();
                if(result != null)
                    yield return result;
            }
        }

        /// <summary>
        /// Decodes encoded assembly instructions
        /// </summary>
        /// <param name="data">The encoded instructions</param>
        public static InstructionBlock decode(AsmCode code)
            => decode(code.Id, code.Label, code.Data);

        /// <summary>
        /// Decodes encoded assembly instructions
        /// </summary>
        /// <param name="data">The encoded instructions</param>
        public static InstructionBlock decode(Moniker id, string label, byte[] data)
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
            return InstructionBlock.Define(id, label, data, dst.ToArray());
		}

        public static MethodAsmBody decode(MethodInfo method)
        {
            var data = NativeReader.read(method);
            if(data.Length == 0)
                throw new NoCodeException(method.ToString());

            var block = new NativeCodeBlock(data.StartAddress, data.Code.Data);
            var instructions = decode(block);                            
            return new MethodAsmBody(method, block, instructions.ToArray());
        }

        public static InstructionBlock decode(INativeMemberData src)
            => decode(src.Id, src.Label, src.Code.Data);

        public static InstructionList decode(NativeCodeBlock src)
		{
            var dst = new InstructionList();
            var reader = new ByteArrayCodeReader(src.Data);
			var decoder = Decoder.Create(IntPtr.Size * 8, reader);
			decoder.IP = src.Address;			
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
        {
            var label = src.Method.Signature().Format();            
            return AsmCodeSet.Define(moniker, decode(src.Code), cil);
        }

        public static AsmCodeSet decode(DynamicDelegate f, Moniker id, byte[] buffer)
            => decode(NativeReader.read(f, buffer), id, f.CilFunc());
    }
}