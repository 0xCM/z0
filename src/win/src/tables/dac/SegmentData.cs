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
    public struct SegmentData
    {
        public ClrDataAddress Address;
        
        public ClrDataAddress Allocated;
        
        public ClrDataAddress Committed;
        
        public ClrDataAddress Reserved;
        
        public ClrDataAddress Used;
        
        public ClrDataAddress Start;
        
        public ClrDataAddress Next;
        
        public ClrDataAddress Heap;
        
        public ClrDataAddress HighAllocMark;
        
        public IntPtr Flags;
        
        public ClrDataAddress BackgroundAllocated;
    }    
}