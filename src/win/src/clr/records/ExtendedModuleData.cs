//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    [Table]
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