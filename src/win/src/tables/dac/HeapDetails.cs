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
    public struct HeapDetails
    {
        public ClrDataAddress Address; // Only filled in in server mode, otherwise NULL
     
        public ClrDataAddress Allocated;
     
        public ClrDataAddress MarkArray;
     
        public ClrDataAddress CAllocateLH;
     
        public ClrDataAddress NextSweepObj;
     
        public ClrDataAddress SavedSweepEphemeralSeg;
     
        public ClrDataAddress SavedSweepEphemeralStart;
     
        public ClrDataAddress BackgroundSavedLowestAddress;
     
        public ClrDataAddress BackgroundSavedHighestAddress;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public GenerationData[] GenerationTable;
        
        public ulong EphemeralHeapSegment;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public ClrDataAddress[] FinalizationFillPointers;
        
        public ClrDataAddress LowestAddress;
        
        public ClrDataAddress HighestAddress;
        
        public ClrDataAddress CardTable;

        public ulong EphemeralAllocContextPtr 
            => GenerationTable[0].AllocationContextPointer;
        
        public ulong EphemeralAllocContextLimit 
            => GenerationTable[0].AllocationContextLimit;

        public ulong FQAllObjectsStart 
            => FinalizationFillPointers[0];
        public ulong FQAllObjectsStop 
            => FinalizationFillPointers[3];
        public ulong FQRootsStart 
            => FinalizationFillPointers[3];
        
        public ulong FQRootsStop 
            => FinalizationFillPointers[5];
    }
}