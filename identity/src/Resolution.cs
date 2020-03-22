//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Identity)]

namespace Z0.Parts
{
    public sealed class Identity : ApiResolution<Identity, Identity.C>
    {
        public Identity() : base(AssemblyId.Identity) {}
        
        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Identity) {} }            
    }
}