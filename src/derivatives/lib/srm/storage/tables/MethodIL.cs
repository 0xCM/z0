//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System.Runtime.InteropServices;

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