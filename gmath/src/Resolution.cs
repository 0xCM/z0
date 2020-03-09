//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.GMath)]

namespace Z0.Resolutions
{
    public sealed class GMath : AssemblyResolution<GMath, GMath.C>
    {        
        public GMath() : base(AssemblyId.GMath) {}

        public class C : OpCatalog<C> { public C() : base(AssemblyId.GMath) {} }    
    }
}