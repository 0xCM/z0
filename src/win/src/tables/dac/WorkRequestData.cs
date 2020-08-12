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
    public struct WorkRequestData
    {
        public ClrDataAddress Function;
        
        public ClrDataAddress Context;
        
        public ClrDataAddress NextWorkRequest;
    }
}