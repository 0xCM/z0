//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Nats)]

namespace Z0.Parts
{
    public sealed class Nats : ApiPart<Nats, Nats.C>
    {
        public Nats() : base(PartId.Nats) {}

        public class C : ApiCatalog<C> { public C() : base(PartId.Nats) {} }
    }
}