//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;

    using static ClrDataModel;

    public struct ExtendedModuleData
    {
        public int IsDynamic;
        
        public int IsInMemory;
        
        public int IsFileLayout;
        
        public ClrDataAddress PEFile;
        
        public ClrDataAddress LoadedPEAddress;
        
        public ulong LoadedPESize; // size of file on disk
        
        public ClrDataAddress InMemoryPdbAddress;
        
        public ulong InMemoryPdbSize;
    }
}