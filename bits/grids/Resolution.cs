//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    public sealed class BitGrids : AssemblyResolution<BitGrids>
    {
        public BitGrids() : base (AssemblyId.BitGrids) {}

        class C : OpCatalog<C> { public C() : base(AssemblyId.BitGrids) { } }
    }
}