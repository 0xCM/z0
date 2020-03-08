//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    public sealed class BitGrids : AssemblyResolution<BitGrids, BitGrids.C>
    {
        public BitGrids() : base (AssemblyId.BitGrids) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.BitGrids) { } }
    }
}