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
    public readonly struct SegmentData
    {
        public readonly ClrDataAddress Address;
        
        public readonly ClrDataAddress Allocated;
        
        public readonly ClrDataAddress Committed;
        
        public readonly ClrDataAddress Reserved;
        
        public readonly ClrDataAddress Used;
        
        public readonly ClrDataAddress Start;
        
        public readonly ClrDataAddress Next;
        
        public readonly ClrDataAddress Heap;
        
        public readonly ClrDataAddress HighAllocMark;
        
        public readonly IntPtr Flags;
        
        public readonly ClrDataAddress BackgroundAllocated;
    }    
}