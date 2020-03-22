//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Nats)]

namespace Z0.Parts
{
    public sealed class Nats : ApiResolution<Nats, Nats.C>
    {
        public Nats() : base(AssemblyId.Nats) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Nats) {} }
    }
}