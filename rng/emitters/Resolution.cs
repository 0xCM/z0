//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    public sealed class RngEmitters : AssemblyResolution<RngEmitters, RngEmitters.C>
    {
        const AssemblyId Identity = AssemblyId.RngEmitters;

        public RngEmitters() : base(Identity) {}
    
        public class C : OpCatalog<C> { public C() : base(Identity) { } }
    }
}