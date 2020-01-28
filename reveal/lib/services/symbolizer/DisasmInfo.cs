//-----------------------------------------------------------------------------
// Taken from https://github.com/0xd4d/JitDasm/tree/master/JitDasm;
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using static zfunc;

    using Iced.Intel;

    partial class Symbolizer
    {
        public sealed class DisasmInfo 
        {
            public readonly uint TypeToken;

            public readonly string TypeFullName;

            public readonly uint MethodToken;

            public readonly string MethodFullName;

            public readonly string MethodName;

            public readonly string ModuleFilename;

            public readonly ILMap[] ILMap;

            public readonly List<NativeCode> Code = new List<NativeCode>();

            public readonly InstructionList Instructions = new InstructionList();

            public DisasmInfo(uint typeToken, string typeFullName, uint methodToken, string methodFullName, string methodName, string moduleFilename, ILMap[] ilMap) {
                TypeToken = typeToken;
                TypeFullName = typeFullName;
                MethodToken = methodToken;
                MethodFullName = methodFullName;
                MethodName = methodName;
                ModuleFilename = moduleFilename;
                ILMap = ilMap;
            }

            public bool Contains(ulong address) 
            {
                foreach (var code in Code) {
                    if ((address - code.IP) < (ulong)code.Code.Length)
                        return true;
                }
                return false;
            }

            public bool TryGetCode(ulong address, out NativeCode nativeCode) 
            {
                foreach (var code in Code) {
                    if ((address - code.IP) < (ulong)code.Code.Length) {
                        nativeCode = code;
                        return true;
                    }
                }
                nativeCode = default;
                return false;
            }
	    }

        public readonly struct NativeCode 
        {
            public readonly ulong IP;
            public readonly byte[] Code;
            public NativeCode(ulong ip, byte[] code) 
            {
                IP = ip;
                Code = code;
            }
        }
    }

}