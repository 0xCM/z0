//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Identity)]

namespace Z0.Parts
{
    public sealed class Identity : ApiPart<Identity, Identity.C>
    {
        public Identity() : base(PartId.Identity) {}
        
        public class C : ApiCatalog<C> { public C() : base(PartId.Identity) {} }            
    }
}