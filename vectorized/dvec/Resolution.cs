//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.DVec)]

namespace Z0.Parts
{
    public sealed class DVec : ApiPart<DVec, DVec.C>
    {
        public DVec() : base(PartId.DVec) {}
        
        public class C : ApiCatalog<C> { public C() : base(PartId.DVec) {} }            
    }
}