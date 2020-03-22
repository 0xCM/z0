//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.BitFields)]

namespace Z0.Parts
{        
    public sealed class BitFields : ApiPart<BitFields, BitFields.C>
    {
        public BitFields() : base(PartId.BitFields) {}

        public class C : ApiCatalog<C> { public C() : base(PartId.BitFields) {} }
    }
}