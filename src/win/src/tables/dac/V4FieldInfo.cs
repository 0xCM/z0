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
    public struct V4FieldInfo
    {
        public short NumInstanceFields;
        
        public short NumStaticFields;
        
        public short NumThreadStaticFields;
        
        public ClrDataAddress FirstFieldAddress; // If non-null, you can retrieve more
        
        public short ContextStaticOffset;
        
        public short ContextStaticsSize;
    }
}