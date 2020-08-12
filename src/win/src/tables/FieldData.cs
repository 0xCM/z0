//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct FieldData
    {
        public readonly uint ElementType; // CorElementType
        
        public readonly uint SigType; // CorElementType
        
        public readonly ClrDataAddress TypeMethodTable; // NULL if Type is not loaded
        
        public readonly ClrDataAddress TypeModule;
        
        public readonly uint TypeToken;
        
        public readonly uint FieldToken;
        
        public readonly ClrDataAddress MTOfEnclosingClass;
        
        public readonly uint Offset;
        
        public readonly uint IsThreadLocal;
        
        public readonly uint IsContextLocal;
        
        public readonly uint IsStatic;
        
        public readonly ClrDataAddress NextField;
    }
}