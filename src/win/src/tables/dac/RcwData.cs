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
    public struct RcwData
    {
        public ClrDataAddress IdentityPointer;
 
        public ClrDataAddress IUnknownPointer;
 
        public ClrDataAddress ManagedObject;
 
        public ClrDataAddress JupiterObject;
 
        public ClrDataAddress VTablePointer;
 
        public ClrDataAddress CreatorThread;
 
        public ClrDataAddress CTXCookie;

        public int RefCount;
 
        public int InterfaceCount;

        public uint IsJupiterObject;
 
        public uint SupportsIInspectable;
 
        public uint IsAggregated;
 
        public uint IsContained;
  
        public uint IsFreeThreaded;
 
        public uint IsDisconnected;
    }
}