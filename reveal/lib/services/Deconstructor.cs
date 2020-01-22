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

        readonly IAsmDecoder Decoder;

        public static AsmFunction[] Functions(Type src)
            => Functions(src.DeclaredMethods().NonGeneric().Concrete().NonSpecial().ToArray()).ToArray();
    
        public static IEnumerable<AsmFunction> Functions(IEnumerable<MethodInfo> methods)
        {
            methods.JitMethods();
            var modules = methods.Select(x => x.Module).Distinct();
            using var decon = new Deconstructor(modules);
            foreach(var m in methods)
            {
                var d = decon.Function(m);
                if(d)
                    yield return d.Value;                    
            }            
        }

        Deconstructor(IEnumerable<Module> modules)
        {            
            Target = DataTarget.AttachToProcess(Process.GetCurrentProcess().Id, uint.MaxValue, AttachFlag.Passive);
            Runtime = CreateRuntime(Target);
            MdIx = ClrMetadataIndex.Create(modules.ToArray());
            Decoder = AsmServices.Decoder(MdIx);
        }

        /// <summary>
        /// Creates a .net core runtime predicated on a  target
        /// </summary>
        /// <param name="target">The target relative type which the runtime abstraction will be created</param>
        static ClrRuntime CreateRuntime(DataTarget target)
            => target.ClrVersions.Single(x => x.Flavor == ClrFlavor.Core).CreateRuntime();

        /// <summary>
        /// Queries the runtime for the runtime method corresponding to a supplied method
        /// </summary>
        /// <param name="rt">The source runtime</param>
        /// <param name="src">The represented method</param>
        Option<ClrMethod> GetRuntimeMethod(MethodInfo src)
            => Runtime.GetMethodByHandle((ulong)src.MethodHandle.Value.ToInt64());
            
        // Option<AsmFunction> Disassemble(Moniker id, MethodInfo method)
        // {
        //     var decoder = AsmServices.Decoder();
        //     try
        //     {
        //         return
        //             from block in ReadNativeContent(id,method)
        //             let code = AsmCode.Define(id, block.Label, block.Encoded)
        //             let cil = MdIx.FindCilFunction(method).ValueOrDefault()
        //             let instructions = decoder.DecodeInstructions(code, block.Location)
        //             let body = MethodAsmBody.Define(method, block, instructions.Decoded)
        //             let f = Builder.BuildFunction(id, CaptureTermCode.MSDIAG, body).WithCil(cil)
        //             select f;
            
        //     }
        //     catch(Exception e)
        //     {
        //         error(e);
        //         return default;
        //     }
        // }
                               
        // IAsmFunctionBuilder Builder
        //     => AsmServices.FunctionBuilder();
        
        void IDisposable.Dispose()
        {
            Target?.Dispose();
        }
		
        // Option<NativeCodeBlock> ReadNativeContent(Moniker id, MethodInfo method) 
		// 	=> from clrmethod in GetRuntimeMethod(method)
        //        from block in ReadNativeBlock(id, method, clrmethod)
        //      select block;

        Option<AsmFunction> Function(MethodInfo method)
            => from runtime in GetRuntimeMethod(method)
               from capture in ReadNativeMethodData(method, runtime)
               let f = Decoder.DecodeFunction(capture)
               select f;

        // Option<NativeMemberCapture> ReadNativeMethodData(MethodInfo method) 
		// 	=> from clr in GetRuntimeMethod(method)
        //         from capture in ReadNativeMethodData(method,clr)
        //         select capture;

		/// <summary>
		/// Reads a continuous block of memory
		/// </summary>
		/// <param name="target">The (source!) target </param>
		/// <param name="address">The starting address</param>
		/// <param name="size">The number of bytes to read</param>
		Option<AsmCode> ReadNativeBlock(Moniker id, string label, ulong address, uint size)
		{
			if (address == 0)
            {
				warn($"Unspecified address for {label}");
                return default;
            }

			if (size == 0)
            {
				warn($"There is no code to read at address = {address.FormatHex(false)} for {label}");
                return default;
            }

			var buffer = new byte[(int)size];
            var actualSize = 0;
			if (!Target.ReadProcessMemory(address, buffer, buffer.Length, out actualSize))            
            {
				warn($"Memory access failure at address {address.FormatHex(false)} for {label}");
                return default;
            }
            
            if (size != actualSize)
            {
                error(Errors.LengthMismatch((int)size, actualSize));
                return default;
            }

			return AsmCode.Define(id, (address, address + size),  label, buffer);
		}

		Option<NativeMemberCapture> ReadNativeMethodData(Moniker id, MethodInfo method, ulong address, uint size)
		{
			var label = method.Signature().Format();
            if (address == 0)
            {
				error($"Unspecified address for {label}");
                return default;
            }

			if (size == 0)
            {
				warn($"There is no code to read at address = {address.FormatHex(false)} for {label}");
                return default;
            }

			var buffer = new byte[(int)size];
            var actualSize = 0;
			if (!Target.ReadProcessMemory(address, buffer, buffer.Length, out actualSize))
            {
				error($"Memory access failure at address {address.FormatHex(false)} for {label}");
                return default;
            }
            
            if (size != actualSize)
            {
                error(Errors.LengthMismatch((int)size, actualSize));
                return default;
            }

            var location = MemoryRange.Define(address, address + size);            
            var result = CaptureResult.Define(location.Start, location.End, CaptureTermCode.MSDIAG, buffer);
			return NativeMemberCapture.Define(id, method, location, buffer, result);
		}

		Option<NativeMemberCapture> ReadNativeMethodData(MethodInfo method, ClrMethod runtime)
		{
			var codeInfo = runtime.HotColdInfo;	
            return ReadNativeMethodData(OpIdentity.Provider.Define(method), method, codeInfo.HotStart, codeInfo.HotSize);
        }

        /// <summary>
        /// Reads the native code blocks that have been Jitted for a specified method
        /// </summary>
        /// <param name="target">The diagnostic target</param>
        /// <param name="runtime">The runtime method</param>
        Option<AsmCode> ReadNativeBlock(Moniker id, MethodInfo info, ClrMethod runtime)
        {
			var codeInfo = runtime.HotColdInfo;	
            return ReadNativeBlock(id, info.Signature().Format(), codeInfo.HotStart, codeInfo.HotSize);
        }
    }
}