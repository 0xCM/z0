//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Identity)]

namespace Z0.Resolutions
{
    public sealed class Identity : AssemblyResolution<Identity, Identity.C>
    {
        public Identity() : base(AssemblyId.Identity) {}
        
        public class C : OpCatalog<C> { public C() : base(AssemblyId.Identity) {} }            
    }
}