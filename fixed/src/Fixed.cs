//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Fixed)]

namespace Z0.Parts
{        
    public sealed class Fixed : ApiPart<Fixed, Fixed.C>
    {
        public Fixed() : base(PartId.Fixed) {}

        public class C : ApiCatalog<C> { public C() : base(PartId.Fixed) { } }            
    }
}