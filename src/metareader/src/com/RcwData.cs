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
    public readonly struct RcwData
    {
        public readonly ClrDataAddress IdentityPointer;
 
        public readonly ClrDataAddress IUnknownPointer;
 
        public readonly ClrDataAddress ManagedObject;
 
        public readonly ClrDataAddress JupiterObject;
 
        public readonly ClrDataAddress VTablePointer;
 
        public readonly ClrDataAddress CreatorThread;
 
        public readonly ClrDataAddress CTXCookie;

        public readonly int RefCount;
 
        public readonly int InterfaceCount;

        public readonly uint IsJupiterObject;
 
        public readonly uint SupportsIInspectable;
 
        public readonly uint IsAggregated;
 
        public readonly uint IsContained;
  
        public readonly uint IsFreeThreaded;
 
        public readonly uint IsDisconnected;
    }
}