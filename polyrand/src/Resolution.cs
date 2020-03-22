//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Polyrand)]

namespace Z0.Parts
{
    public sealed class Polyrand : ApiPart<Polyrand, Polyrand.C>
    {
        public Polyrand() : base(PartId.Polyrand) {}
        
        public class C : ApiCatalog<C> { public C() : base(PartId.Polyrand) {} }            
    }
}