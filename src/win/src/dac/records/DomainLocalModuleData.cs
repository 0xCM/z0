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
    public readonly struct DomainLocalModuleData
    {
        public readonly ClrDataAddress AppDomainAddress;
        
        public readonly ulong ModuleID;

        public readonly ClrDataAddress ClassData;
        
        public readonly ClrDataAddress DynamicClassTable;
        
        public readonly ClrDataAddress GCStaticDataStart;
        
        public readonly ClrDataAddress NonGCStaticDataStart;
    }
}