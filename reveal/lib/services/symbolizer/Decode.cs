//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using Microsoft.Diagnostics.Runtime;

    using static zfunc;

    using Iced.Intel;

    /// <summary>
    /// The symbolizer code is based on code extraced from https://github.com/0xd4d/JitDasm/tree/master/JitDasm; see license file
    /// </summary>
    static partial class Symbolizer
    {
		const ulong MIN_ADDR = 0x10000;

		// Decode everything on one thread to get possible symbol values. Could be sped up of we use parallel for
		// then on the main thread, we use CLRMD (not thread safe), and then parallel for to disassemble them.
		public static void DecodeInstructions(KnownSymbols knownSymbols, ClrRuntime runtime, DisasmInfo disasmInfo) 
        {
			var instrs = disasmInfo.Instructions;
			foreach (var info in disasmInfo.Code) {
				var reader = new ByteArrayCodeReader(info.Code);
				var decoder = Decoder.Create(runtime.PointerSize * 8, reader);
				decoder.IP = info.IP;
				while (reader.CanReadByte) {
					ref var instr = ref instrs.AllocUninitializedElement();
					decoder.Decode(out instr);
					int opCount = instr.OpCount;
					var symFlags = AddSymbolFlags.None;
					if (opCount == 1) {
						switch (instr.Code) {
						case Code.Call_rm32:
						case Code.Call_rm64:
						case Code.Jmp_rm32:
						case Code.Jmp_rm64:
							symFlags |= AddSymbolFlags.CallMem | AddSymbolFlags.CanBeMethod;
							break;
						}
					}
					for (int j = 0; j < opCount; j++) {
						switch (instr.GetOpKind(j)) {
						case OpKind.NearBranch16:
						case OpKind.NearBranch32:
						case OpKind.NearBranch64:
							AddSymbol(knownSymbols, runtime, instr.NearBranchTarget, symFlags | AddSymbolFlags.CanBeMethod);
							break;

						case OpKind.FarBranch16:
						case OpKind.FarBranch32:
							break;

						case OpKind.Immediate32:
							if (runtime.PointerSize == 4)
								AddSymbol(knownSymbols, runtime, instr.GetImmediate(j), symFlags | AddSymbolFlags.CanBeMethod);
							break;

						case OpKind.Immediate64:
							AddSymbol(knownSymbols, runtime, instr.GetImmediate(j), symFlags | AddSymbolFlags.CanBeMethod);
							break;

						case OpKind.Immediate16:
						case OpKind.Immediate8to16:
						case OpKind.Immediate8to32:
						case OpKind.Immediate8to64:
						case OpKind.Immediate32to64:
							AddSymbol(knownSymbols, runtime, instr.GetImmediate(j), symFlags);
							break;

						case OpKind.Memory64:
							AddSymbol(knownSymbols, runtime, instr.MemoryAddress64, symFlags);
							break;

						case OpKind.Memory:
							if (instr.IsIPRelativeMemoryOperand)
								AddSymbol(knownSymbols, runtime, instr.IPRelativeMemoryAddress, symFlags);
							else {
								switch (instr.MemoryDisplSize) {
								case 4:
									if (runtime.PointerSize == 4)
										AddSymbol(knownSymbols, runtime, instr.MemoryDisplacement, symFlags);
									break;

								case 8:
									AddSymbol(knownSymbols, runtime, (ulong)(int)instr.MemoryDisplacement, symFlags);
									break;
								}
							}
							break;
						}
					}
				}
			}
		}

		public static void AddSymbol(KnownSymbols knownSymbols, ClrRuntime runtime, ulong address, AddSymbolFlags flags) 
        {
			if (address < MIN_ADDR)
				return;
			if (knownSymbols.IsBadOrKnownSymbol(address))
				return;
			if (TryGetSymbolCore(runtime, address, flags, out var symbol))
				knownSymbols.Add(address, symbol);
			else
				knownSymbols.Bad(address);
		}

		public static bool TryGetSymbolCore(ClrRuntime runtime, ulong address, AddSymbolFlags flags, out SymbolResult result) 
        {
			if (address < MIN_ADDR) 
            {
				result = default;
				return false;
			}

			string name;

			name = runtime.GetJitHelperFunctionName(address);
			if (!(name is null)) {
				result = new SymbolResult(address, name, FormatterOutputTextKind.Function);
				return true;
			}

			name = runtime.GetMethodTableName(address);
			if (!(name is null)) {
				result = new SymbolResult(address, "methodtable(" + name + ")", FormatterOutputTextKind.Data);
				return true;
			}

			var method = runtime.GetMethodByAddress(address);
			if (method is null && (address & ((uint)runtime.PointerSize - 1)) == 0 && (flags & AddSymbolFlags.CallMem) != 0) {
				if (runtime.ReadPointer(address, out ulong newAddress) && newAddress >= MIN_ADDR)
					method = runtime.GetMethodByAddress(newAddress);
			}
			if (!(method is null) && (flags & AddSymbolFlags.CanBeMethod) == 0) 
            {
				// There can be data at the end of the method, after the code. Don't return a method symbol.
				//		vdivsd    xmm2,xmm2,[Some.Type.Method(Double)]	; wrong
				var info = method.HotColdInfo;
				bool isCode = ((address - info.HotStart) < info.HotSize) || ((address - info.ColdStart) < info.ColdSize);
				if (!isCode)
					method = null;
			}
			if (!(method is null)) {
				result = new SymbolResult(address, method.ToString() ?? "???", FormatterOutputTextKind.Function);
				return true;
			}

			result = default;
			return false;
		}
    }
}