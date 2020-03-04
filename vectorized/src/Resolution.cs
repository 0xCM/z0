//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    public sealed class Vectorized : AssemblyResolution<Vectorized, Vectorized.C>
    {
        const AssemblyId Identity = AssemblyId.Vectorized;

        public Vectorized() : base(Identity) {}

        public class C : OpCatalog<C> { public C() : base(Identity) {} }    
    }   
}