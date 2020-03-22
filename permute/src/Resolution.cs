//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Permute)]

namespace Z0.Parts
{
    public sealed class Permute : ApiResolution<Permute, Permute.C>
    {
        public Permute() : base(AssemblyId.Permute) {}
        
        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Permute) {} }            
    }
}