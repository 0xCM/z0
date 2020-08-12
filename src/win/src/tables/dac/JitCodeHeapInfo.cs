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
    public struct JitCodeHeapInfo
    {
        public CodeHeapType Type;
        
        public ClrDataAddress Address;
        
        public ClrDataAddress CurrentAddress;
    }
}