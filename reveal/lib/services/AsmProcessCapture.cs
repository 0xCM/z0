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

    using Z0.Asm;

    using static Root;
    
    class AsmProcessCapture : IAsmProcessCapture
    {
        public static IAsmProcessCapture Create(IAsmContext context)
            => new AsmProcessCapture(context);

        readonly IAsmContext Context;
        
        readonly IClrIndex ClrIndex;

        readonly DataTarget Target;

        readonly ClrRuntime Runtime;

        readonly IAsmFunctionDecoder Decoder;

        AsmProcessCapture(IAsmContext context)
        {            
            Context = context;
            ClrIndex = context.ClrIndex;
            Target = DataTarget.AttachToProcess(Process.GetCurrentProcess().Id, uint.MaxValue, AttachFlag.Passive);
            Runtime = CreateRuntime(Target);
            Decoder = context.FunctionDecoder();
        }
            
        void IDisposable.Dispose()
        {
            Target?.Dispose();
        }
		
        Option<AsmFunction> CaptureFunction(MethodInfo method)
            => from runtime in GetRuntimeMethod(method)
               from capture in CaptureNative(method, runtime)
               let f = Decoder.DecodeFunction(capture)
               select f;

        [MethodImpl(Inline)]
        static IntPtr jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        public IEnumerable<AsmFunction> CaptureFunctions(IEnumerable<MethodInfo> methods)
        {
            foreach(var m in methods)
                jit(m);

            foreach(var m in methods)
            {
                var d = CaptureFunction(m);
                d.OnNone(() => term.warn($"Failed to capture {m.Name}"));
                if(d)
                    yield return d.Value;                    
            }            
        }
        public AsmFunction[] CaptureFunctions(Type src)
            => CaptureFunctions(src.DeclaredMethods().NonGeneric().Concrete().NonSpecial()).ToArray();

        /// <summary>
        /// Creates a .net core runtime predicated on a  target
        /// </summary>
        /// <param name="target">The target relative type which the runtime abstraction will be created</param>
        ClrRuntime CreateRuntime(DataTarget target)
            => target.ClrVersions.Single(x => x.Flavor == ClrFlavor.Core).CreateRuntime();

        /// <summary>
        /// Queries the runtime for the runtime method corresponding to a supplied method
        /// </summary>
        /// <param name="rt">The source runtime</param>
        /// <param name="src">The represented method</param>
        Option<ClrMethod> GetRuntimeMethod(MethodInfo src)
            => Runtime.GetMethodByHandle((ulong)src.MethodHandle.Value.ToInt64());

		Option<AsmOpExtract> CaptureNative(MethodInfo method, ClrMethod runtime)
		{
			var codeInfo = runtime.HotColdInfo;	
            var id = Identity.identify(method);
            var address = codeInfo.HotStart;
            var size = codeInfo.HotSize;            

			var label = method.Signature().Format();
            if (address == 0)
            {
				term.error($"Unspecified address for {label}");
                return default;
            }

			if (size == 0)
            {
				term.warn($"There is no code to read at address = {address.FormatHex(false)} for {label}");
                return default;
            }

			var buffer = new byte[(int)size];
            var actualSize = 0;
			if (!Target.ReadProcessMemory(address, buffer, buffer.Length, out actualSize))
            {
				term.error($"Memory access failure at address {address.FormatHex(false)} for {label}");
                return default;
            }
            
            if (size != actualSize)
            {
                term.error(errors.LengthMismatch((int)size, actualSize));
                return default;
            }

            var location = MemoryRange.Define(address, address + size);            
            var result = AsmCaptureOutcome.Define(AsmCaptureState.Empty, location.Start, location.End, CaptureTermCode.CTC_MSDIAG);
            var bits = AsmCaptureBits.Define(address, buffer,buffer);
			return AsmOpExtract.Define(id, method, location, bits, result.TermCode);                    
        }
    }
}