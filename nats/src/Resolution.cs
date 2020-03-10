//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Nats)]

namespace Z0.Resolutions
{
    public sealed class Nats : AssemblyResolution<Nats, Nats.C>
    {
        public Nats() : base(AssemblyId.Nats) {}

        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.Nats) {} }
    }
}