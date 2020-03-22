//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Dynamic)]

namespace Z0.Parts
{
    public sealed class Dynamic : ApiPart<Dynamic, Dynamic.C>
    {
        public Dynamic() : base(PartId.Dynamic) {}

        public class C : ApiCatalog<C> { public C() : base(PartId.Dynamic) { } }               
    }
}