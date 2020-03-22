//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.BitPack)]

namespace Z0.Parts
{        
    public sealed class BitPack : ApiPart<BitPack, BitPack.C>
    {
        public BitPack() : base (PartId.BitPack) {}

        public class C : ApiCatalog<C> { public C() : base(PartId.BitPack) { } }
    }
}