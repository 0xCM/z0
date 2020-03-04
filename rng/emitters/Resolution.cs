//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    public sealed class RngEmitters : AssemblyResolution<RngEmitters, RngEmitters.C>
    {
        public RngEmitters() : base(AssemblyId.RngEmitters) {}
    
        public class C : OpCatalog<C> { public C() : base(AssemblyId.RngEmitters) { } }
    }
}