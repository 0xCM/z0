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
    public readonly struct ISOSStackRefEnumVTable
    {
        public readonly IntPtr Skip;
        
        public readonly IntPtr Reset;
        
        public readonly IntPtr GetCount;
        
        public readonly IntPtr Next;
    }
}