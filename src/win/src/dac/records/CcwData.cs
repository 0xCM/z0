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
    public readonly struct CcwData
    {
        public readonly ClrDataAddress OuterIUnknown;
        
        public readonly ClrDataAddress ManagedObject;
        
        public readonly ClrDataAddress Handle;
        
        public readonly ClrDataAddress CCWAddress;

        public readonly int RefCount;
        
        public readonly int InterfaceCount;
        
        public readonly uint IsNeutered;

        public readonly int JupiterRefCount;
        
        public readonly uint IsPegged;
        
        public readonly uint IsGlobalPegged;
        
        public readonly uint HasStrongRef;
        
        public readonly uint IsExtendsCOMObject;
        
        public readonly uint HasWeakReference;
        
        public readonly uint IsAggregated;
    }
}