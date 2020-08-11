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
    public readonly struct RejitData
    {
        public readonly ClrDataAddress RejitID;
        
        public readonly uint Flags;
        
        public readonly ClrDataAddress NativeCodeAddr;
    }    
}