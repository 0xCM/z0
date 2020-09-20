//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    using static Part;

    partial struct ClrStorage
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodIL
        {
            public bool LocalVariablesInited;

            public ushort MaxStack;

            public uint LocalSignatureToken;

            public MemoryBlock EncodedILMemoryBlock;

            public SEHTableEntry[]  SEHTable;
        }
    }
}