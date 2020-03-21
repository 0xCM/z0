//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.BitGrids)]

namespace Z0.Resolutions
{        
    public sealed class BitGrids : ApiResolution<BitGrids, BitGrids.C>
    {
        public BitGrids() : base (AssemblyId.BitGrids) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.BitGrids) { } }
    }
}