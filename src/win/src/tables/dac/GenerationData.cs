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
    public struct GenerationData
    {
        public ClrDataAddress StartSegment;
        
        public ClrDataAddress AllocationStart;

        // These are examined only for generation 0, otherwise NULL
        public ClrDataAddress AllocationContextPointer;
        
        public ClrDataAddress AllocationContextLimit;
    }
}