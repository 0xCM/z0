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
    using System.Diagnostics;
    using Microsoft.Diagnostics.Runtime;
	using Iced.Intel;

    using static zfunc;
    

    /// <summary>
    /// Disassembles CLR methods
    /// </summary>
    /// <remarks>The implementation details were greatly facilitated by the following projects:
    /// SharpLab: https://github.com/ashmind/SharpLab
    /// JitDasm:  https://github.com/0xd4d/JitDasm
    /// SeeJit:   https://github.com/JeffreyZhao/SeeJit
    /// </remarks>
    public class Deconstructor : IDisposable
    {
        readonly DataTarget Target;

        readonly ClrRuntime Runtime;

        readonly ClrMetadataIndex MdIx;

        /// <summary>
        /// Disassembles reified methods declared by the source type
        /// </summary>
        /// <param name="src">The source type</param>
        public static MethodDisassembly[] Deconstruct(Type src)
            => Deconstruct(src.DeclaredMethods().NonGeneric().Concrete().NonSpecial().ToArray()).ToArray();
    
                  
        public static IEnumerable<MethodDisassembly> Deconstruct(IEnumerable<MethodInfo> methods)
        {
            methods.JitMethods();
            var modules = methods.Select(x => x.Module).Distinct();
            using var decon = new Deconstructor(modules);
            foreach(var m in methods)
            {
                var d = decon.Disassemble(m);
                if(d)
                    yield return d.ValueOrDefault();
            }            
        }
        
        Deconstructor(IEnumerable<Module> modules)
        {
            Target = DataTarget.AttachToProcess(Process.GetCurrentProcess().Id, uint.MaxValue, AttachFlag.Passive);
            Runtime = CreateRuntime(Target);
            MdIx = ClrMetadataIndex.Create(modules.ToArray());
        }

        /// <summary>
        /// Creates a .net core runtime predicated on a  target
        /// </summary>
        /// <param name="target">The target relative type which the runtime abstraction will be created</param>
        static ClrRuntime CreateRuntime(DataTarget target)
            => target.ClrVersions.Single(x => x.Flavor == ClrFlavor.Core).CreateRuntime();

        /// <summary>
        /// Queries the runtime for the runtime method corresponding to a supplied <see cref='MethodInfo'/>
        /// </summary>
        /// <param name="rt">The source runtime</param>
        /// <param name="src">The represented method</param>
        ClrMethod GetRuntimeMethod(MethodInfo src)
            =>  Runtime.GetMethodByHandle((ulong)src.MethodHandle.Value.ToInt64());
            
        Option<MethodDisassembly> Disassemble(MethodInfo method)
        {
            try
            {
                var clrMethod = GetRuntimeMethod(method);
                if(clrMethod == null || clrMethod.NativeCode == 0)
                {
                    error($"Method {method.Name} not found");
                    return default;
                }
                var id = OpIdentity.Provider.Define(method);
                var asmBody = DecodeAsm(method);
                var cilfunc = MdIx.FindCilFunction(method).ValueOrDefault();                        
                return MethodDisassembly.Define(id, asmBody, cilfunc);
            }
            catch(NoCodeException)
            {
                warn($"{method.DisplayName()}: No code was found");
                return none<MethodDisassembly>();
            }
            catch(Exception e)
            {
                error(e);
                return none<MethodDisassembly>();
            }
        }

        MethodAsmBody DecodeAsm(MethodInfo method)
        {
            var result = from block in ReadNativeContent(method)
                          let instructions = AsmDecoder.list(block)
                        select MethodAsmBody.Define(method, block, instructions);
            return result.OnNone(() => throw new NoCodeException(method.ToString())).Value;
        }

        void IDisposable.Dispose()
        {
            Target?.Dispose();
        }
		
        /// <summary>
        /// Establishes a correlation between a block of CIL and and block of native code
        /// </summary>
        readonly struct CilNativeMap 
        {
            public CilNativeMap(int cilOffset, ulong startAddress, ulong endAddress)
            {
                this.CilOffset = cilOffset;
                this.StartAddress = startAddress;
                this.EndAddress = endAddress;
            }
            
            public readonly int CilOffset; 
            
            public readonly ulong StartAddress;
            
            public readonly ulong EndAddress;
        }

        static CilNativeMap[] MapCilToNative(ClrMethod method)
        {
            var map = method.ILOffsetMap;
            var result = new CilNativeMap[map.Length];
            for (int i = 0; i < result.Length; i++) 
            {
                ref var m = ref map[i];
                result[i] = new CilNativeMap 
                (
                    m.ILOffset,
                    m.StartAddress,
                    m.EndAddress
                );
            }

            Array.Sort(result, (a, b) => 
            {
                int c = a.StartAddress.CompareTo(b.StartAddress);
                if (c != 0)
                    return c;
                return a.EndAddress.CompareTo(b.EndAddress);
            });

            return result;
        }

        byte[] ReadCilBytes(ClrMethod method)
        {
            var ilAddress = method.IL.Address;
            var ilSize = method.IL.Length;
            var ilBytes = new byte[ilSize];
            Target.ReadProcessMemory(ilAddress,ilBytes, ilSize, out int ilRead);
            require(ilRead == ilSize);                    
            return ilBytes;
        }

        Option<NativeCodeBlock> ReadNativeContent(MethodInfo method) 
			=> ReadNativeBlock(method, GetRuntimeMethod(method));


		/// <summary>
		/// Reads a continuous block of memory
		/// </summary>
		/// <param name="target">The (source!) target </param>
		/// <param name="address">The starting address</param>
		/// <param name="size">The number of bytes to read</param>
		Option<NativeCodeBlock> ReadNativeBlock(string label, ulong address, uint size)
		{
			if (address == 0 || size == 0)
				return zfunc.none<NativeCodeBlock>();

			var dst = new byte[(int)size];
			if (!Target.ReadProcessMemory(address, dst, dst.Length, out int bytesRead))
				throw new Exception($"Memory access failure at address {address.FormatHex()}");
            
            if (dst.Length != size)
                throw Errors.LengthMismatch((int)size, dst.Length);

			return NativeCodeBlock.Define(label, address, dst);
		}

        /// <summary>
        /// Reads the native code blocks that have been Jitted for a specified method
        /// </summary>
        /// <param name="target">The diagnostic target</param>
        /// <param name="runtime">The runtime method</param>
        Option<NativeCodeBlock> ReadNativeBlock(MethodInfo info, ClrMethod runtime)
        {
			var codeInfo = runtime.HotColdInfo;	
            return ReadNativeBlock(info.Signature().Format(),codeInfo.HotStart, codeInfo.HotSize);
        }
    }
}