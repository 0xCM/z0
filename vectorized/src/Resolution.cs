//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Vectorized)]

namespace Z0.Resolutions
{
    public sealed class Vectorized : ApiResolution<Vectorized, Vectorized.C>
    {
        public Vectorized() : base(AssemblyId.Vectorized) {}

        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Vectorized) {} }    
    }   
}