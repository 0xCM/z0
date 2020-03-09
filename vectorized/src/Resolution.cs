//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Vectorized)]

namespace Z0.Resolutions
{
    public sealed class Vectorized : AssemblyResolution<Vectorized, Vectorized.C>
    {
        public Vectorized() : base(AssemblyId.Vectorized) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.Vectorized) {} }    
    }   
}