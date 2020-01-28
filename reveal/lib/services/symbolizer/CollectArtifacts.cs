//-----------------------------------------------------------------------------
// Taken from https://github.com/0xd4d/JitDasm/tree/master/JitDasm;
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.Diagnostics.Runtime;
    using System.IO;

    using static zfunc;

    static partial class Symbolizer
    {
        static bool IsSameType(ClrType a, ClrType b) => a.Module == b.Module && a.MetadataToken == b.MetadataToken;

        static IEnumerable<ClrType> EnumerateTypes(ClrModule module, bool heapSearch) 
        {
            var types = new HashSet<ClrType>();
            foreach (var type in EnumerateTypesCore(module, heapSearch)) 
            {
                if (types.Add(type))
                    yield return type;
            }
        }

		static void ReadCode(DataTarget dataTarget, DisasmInfo info, ulong startAddr, uint size) 
        {
			if (startAddr == 0 || size == 0)
				return;
			var code = new byte[(int)size];
			if (!dataTarget.ReadProcessMemory(startAddr, code, code.Length, out int bytesRead) || bytesRead != code.Length)
				throw new ApplicationException($"Couldn't read process memory @ 0x{startAddr:X}");
			info.Code.Add(new NativeCode(startAddr, code));
		}

		static ILMap[] CreateILMap(ILToNativeMap[] map) {
			var result = new ILMap[map.Length];
			for (int i = 0; i < result.Length; i++) {
				ref var m = ref map[i];
				result[i] = new ILMap {
					ilOffset = m.ILOffset,
					nativeStartAddress = m.StartAddress,
					nativeEndAddress = m.EndAddress,
				};
			}
			Array.Sort(result, (a, b) => {
				int c = a.nativeStartAddress.CompareTo(b.nativeStartAddress);
				if (c != 0)
					return c;
				return a.nativeEndAddress.CompareTo(b.nativeEndAddress);
			});

			return result;
		}

		static DisasmInfo CreateDisasmInfo(DataTarget dataTarget, ClrMethod method) 
        {
			var info = new DisasmInfo(method.Type.MetadataToken, method.Type.Name, method.MetadataToken, method.ToString() ?? "???", method.Name, method.Type.Module.IsFile ? method.Type.Module.FileName : null, CreateILMap(method.ILOffsetMap));
			var codeInfo = method.HotColdInfo;
			ReadCode(dataTarget, info, codeInfo.HotStart, codeInfo.HotSize);
			ReadCode(dataTarget, info, codeInfo.ColdStart, codeInfo.ColdSize);
			return info;
		}

        static (int bitness, DisasmInfo[] methods, KnownSymbols knownSymbols) GetMethodsToDisassemble(int pid, string moduleName, MemberFilter typeFilter, MemberFilter methodFilter, bool heapSearch) {
            var methods = new List<DisasmInfo>();
            var knownSymbols = new KnownSymbols();
            int bitness;
            using (var dataTarget = DataTarget.AttachToProcess(pid, 0, AttachFlag.Passive)) {
                if (dataTarget.ClrVersions.Count == 0)
                    throw new ApplicationException("Couldn't find CLR/CoreCLR");
                if (dataTarget.ClrVersions.Count > 1)
                    throw new ApplicationException("Found more than one CLR/CoreCLR");
                var clrInfo = dataTarget.ClrVersions[0];
                var clrRuntime = clrInfo.CreateRuntime(clrInfo.LocalMatchingDac);
                bitness = clrRuntime.PointerSize * 8;

                // Per https://github.com/microsoft/clrmd/issues/303
                dataTarget.DataReader.Flush();

                var module = clrRuntime.Modules.FirstOrDefault(a =>
                    StringComparer.OrdinalIgnoreCase.Equals(a.Name, moduleName) ||
                    StringComparer.OrdinalIgnoreCase.Equals(Path.GetFileNameWithoutExtension(a.Name), moduleName) ||
                    StringComparer.OrdinalIgnoreCase.Equals(a.FileName, moduleName));
                if (module is null)
                    throw new ApplicationException($"Couldn't find module '{moduleName}'");

                foreach (var type in EnumerateTypes(module, heapSearch)) {
                    if (!typeFilter.IsMatch(type.Name, type.MetadataToken))
                        continue;
                    foreach (var method in type.Methods) {
                        if (!IsSameType(method.Type, type))
                            continue;
                        if (method.CompilationType == MethodCompilationType.None)
                            continue;
                        if (!methodFilter.IsMatch(method.Name, method.MetadataToken))
                            continue;
                        var disasmInfo = CreateDisasmInfo(dataTarget, method);
                        DecodeInstructions(knownSymbols, clrRuntime, disasmInfo);
                        methods.Add(disasmInfo);
                    }
                }
            }
            return (bitness, methods.ToArray(), knownSymbols);
        }


		static IEnumerable<ClrType> EnumerateTypesCore(ClrModule module, bool heapSearch) 
        {
			foreach (var type in module.EnumerateTypes())
				yield return type;

			if (heapSearch) {
				foreach (var obj in module.Runtime.Heap.EnumerateObjects()) {
					var type = obj.Type;
					if (type?.Module == module)
						yield return type;
				}
			}
		}

    }

}