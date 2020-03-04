//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    public sealed class AsmCore : AssemblyResolution<AsmCore>
    {
        const AssemblyId Identity = AssemblyId.AsmCore;

        public AsmCore() : base(Identity) {}

        public class C : OpCatalog<C> { public C() : base(Identity) { } }
    }
}