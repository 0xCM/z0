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

    using static ClrDataModel;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct AppDomainData
    {
        public readonly ClrDataAddress Address;
        public readonly ClrDataAddress SecurityDescriptor;
        public readonly ClrDataAddress LowFrequencyHeap;
        public readonly ClrDataAddress HighFrequencyHeap;
        public readonly ClrDataAddress StubHeap;
        public readonly ClrDataAddress DomainLocalBlock;
        public readonly ClrDataAddress DomainLocalModules;
        public readonly int Id;
        public readonly int AssemblyCount;
        public readonly int FailedAssemblyCount;
        public readonly int Stage;
    }    
}