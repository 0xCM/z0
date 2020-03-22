//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Polyrand)]

namespace Z0.Parts
{
    public sealed class Polyrand : ApiResolution<Polyrand, Polyrand.C>
    {
        public Polyrand() : base(AssemblyId.Polyrand) {}
        
        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Polyrand) {} }            
    }
}