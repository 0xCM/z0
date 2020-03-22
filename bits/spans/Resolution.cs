//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.BitSpan)]

namespace Z0.Parts
{        
    public sealed class BitSpan : ApiPart<BitSpan, BitSpan.C>
    {
        public BitSpan() : base(PartId.BitSpan) {}

        public class C : ApiCatalog<C> { public C() : base(PartId.BitSpan) { } }
    }
}