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

    public struct MethodTableCollectibleData
    {
        public ClrDataAddress LoaderAllocatorObjectHandle;
        
        public uint Collectible;
    }
}