//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Intrinsics)]

namespace Z0.Parts
{
    public sealed class Intrinsics : ApiPart<Intrinsics, Intrinsics.C>
    {        
        public Intrinsics() : base(PartId.Intrinsics) {}

        public class C : ApiCatalog<C> { public C() : base(PartId.Intrinsics) { } }
    }
}