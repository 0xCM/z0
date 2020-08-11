//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct V4FieldInfo
    {
        public readonly short NumInstanceFields;
        
        public readonly short NumStaticFields;
        
        public readonly short NumThreadStaticFields;
        
        public readonly ClrDataAddress FirstFieldAddress; // If non-null, you can retrieve more
        
        public readonly short ContextStaticOffset;
        
        public readonly short ContextStaticsSize;
    }
}