//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    public sealed class FastOps : AssemblyResolution<FastOps, FastOps.C>
    {
        const AssemblyId Identity = AssemblyId.FreeId;

        public FastOps() : base(Identity) {}

        public class C : OpCatalog<C> { public C() : base(Identity) { } }
    }
}