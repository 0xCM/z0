//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.BitVectors)]

namespace Z0.Resolutions
{        
    public sealed class BitVectors : AssemblyResolution<BitVectors, BitVectors.C>
    {
        public BitVectors() : base(AssemblyId.BitVectors) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.BitVectors) { } }
    }
}

