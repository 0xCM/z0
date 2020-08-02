//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct GenerationData
    {
        public readonly ClrDataAddress StartSegment;
        
        public readonly ClrDataAddress AllocationStart;

        // These are examined only for generation 0, otherwise NULL
        public readonly ClrDataAddress AllocationContextPointer;
        
        public readonly ClrDataAddress AllocationContextLimit;
    }
}