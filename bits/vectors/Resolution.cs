//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.BitVectors)]

namespace Z0.Parts
{        
    public sealed class BitVectors : ApiPart<BitVectors, BitVectors.C>
    {
        public BitVectors() : base(PartId.BitVectors) {}

        public class C : ApiCatalog<C> { public C() : base(PartId.BitVectors) { } }
    }
}

