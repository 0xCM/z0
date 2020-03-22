//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Logix)]

namespace Z0.Parts
{        
    public sealed class Logix : ApiPart<Logix, Logix.C>
    {
        public Logix() : base(PartId.Logix) {}

        public class C : ApiCatalog<C> { public C() : base(PartId.Logix) { } }
    }
}