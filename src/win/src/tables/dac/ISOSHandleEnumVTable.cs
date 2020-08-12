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

    [Table, StructLayout(LayoutKind.Sequential)]
    public struct ISOSHandleEnumVTable
    {
        public IntPtr Skip;
        
        public IntPtr Reset;
        
        public IntPtr GetCount;
        
        public IntPtr Next;
    } 
}