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
    public readonly struct WorkRequestData
    {
        public readonly ClrDataAddress Function;
        
        public readonly ClrDataAddress Context;
        
        public readonly ClrDataAddress NextWorkRequest;
    }
}